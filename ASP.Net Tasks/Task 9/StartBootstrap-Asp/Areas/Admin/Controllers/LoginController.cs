using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using System.Threading.Tasks;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
	[Area("admin")]
    [Authorize]
    public class LoginController : Controller
	{
        private readonly AppDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(AppDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login()
		{
			return View();
		}


		[HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(CostumeUser model)
        {
			if (model.UserName != null && model.PasswordHash != null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.PasswordHash, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login or PassWord is not correct");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Login or Password is not valid");
                return View(model);
            }
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }


	}
}
