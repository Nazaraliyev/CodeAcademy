using Biziness.Data;
using Biziness.Models;
using Biziness.View_Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Biziness.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class AccountController : Controller
    {
		private readonly AppDbContext _context;
		private readonly UserManager<CustomUser> _userManager;
		private readonly SignInManager<CustomUser> _signInManager;

		public AccountController(AppDbContext context, UserManager<CustomUser> userManager, SignInManager<CustomUser> signInManager)
		{
			_context = context;
			_userManager = userManager;
			_signInManager = signInManager;
		}
        public async Task<IActionResult> Index()
        {
            return View(await _context.customUsers.ToListAsync());
        }


        public IActionResult Create()
		{
            return View();
		}


        [HttpPost]
        public async Task<IActionResult> Create(VmUserCreate model)
        {
			if (!ModelState.IsValid)
			{
                return View(model);
			}

            CustomUser user = new CustomUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.Email,
                PhoneNumber = model.Phone,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

			if (result.Succeeded)
			{
                return RedirectToAction(nameof(Index));
			}

            return View(model);
        }



        public async Task<IActionResult> Update(string Id)
		{
            if (Id == null)
            {
                return NotFound();
            }

            if (await _userManager.FindByIdAsync(Id) == null)
            {
                return NotFound();
            }

            CustomUser user = await _userManager.FindByIdAsync(Id);
            VmUserUpdate Vmuser = new VmUserUpdate()
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Phone = user.PhoneNumber,
                Id = user.Id
            };
            return View(Vmuser);
		}

        [HttpPost]
        public async Task<IActionResult> Update(VmUserUpdate model)
		{
			if (!ModelState.IsValid)
			{
                return View(model);
			}

            CustomUser user = await _userManager.FindByIdAsync(model.Id);

            user.Name = model.Name;
            user.Email = model.Email;
            user.Surname = model.Surname;
            user.PhoneNumber = model.Phone;

            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
		}


        public async Task<IActionResult> Delete(string Id)
		{
            if(Id == null)
			{
                return NotFound();
			}

            if(await _userManager.FindByIdAsync(Id) == null)
			{
                return NotFound();
			}

            var result = await _userManager.DeleteAsync(await _userManager.FindByIdAsync(Id));
			if (result.Succeeded)
			{
                return RedirectToAction(nameof(Index));
			}

            return NotFound();
		} 



        [AllowAnonymous]
        public IActionResult Login()
		{
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
		 }


        [HttpPost]
        public async Task<IActionResult> Login(VmUserLogin model)
        {
			if (!ModelState.IsValid)
			{
                return View(model);
			}

            var result = await _signInManager.PasswordSignInAsync(model.Login, model.Password, false, false);
			if (result.Succeeded)
			{
                return RedirectToAction(nameof(Index));
			}

            ModelState.AddModelError("", "Login or Password is not correct");
            return View(model);
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));

        }
    }
}
