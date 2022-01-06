using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repair.Areas.Admin.ViewModel;
using Repair.Models;
using System;
using System.Threading.Tasks;

namespace Repair.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Login(VmRegister model)
        {
            if (ModelState.IsValid && model.Mail != null && model.Password != null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Mail, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Mail or Password is not correct");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Mail or Password is not correct");
                return View(model);
            }
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                CostumeUser user = new CostumeUser()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Fullname = model.Name + model.Surname,
                    Adress = model.Address,
                    PhoneNumber = model.Phone,
                    Email = model.Mail,
                    UserName = model.Mail,
                    CreateTime = DateTime.Now
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }

            return View(model);
        }



        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }

}
