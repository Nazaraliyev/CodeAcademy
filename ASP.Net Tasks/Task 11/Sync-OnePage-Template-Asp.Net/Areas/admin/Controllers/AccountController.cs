using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sync_OnePage_Template_Asp.Net.Data;
using Sync_OnePage_Template_Asp.Net.Models;
using Sync_OnePage_Template_Asp.Net.ViewModel;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_OnePage_Template_Asp.Net.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(AppDbContext context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            ViewBag.UserRoles = _context.UserRoles.ToList();
            ViewBag.Roles = _context.Roles.ToList();
            return View(_context.costumeUsers.ToList());
        }


        public IActionResult Create()
        {
            VmUserRegister model = new VmUserRegister()
            {
                Role = _roleManager.Roles.ToList()
            };
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Create(VmUserRegister model)
        {
            model.Role = _roleManager.Roles.ToList();
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg")
                    {
                        if (model.ImageFile.Length <= 5242880)
                        {
                            string filename = Guid.NewGuid() + "-" + model.ImageFile.FileName;
                            string filepath = Path.Combine("wwwroot", "assets/img/profiles", filename);
                            using (var stream = new FileStream(filepath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }
                            model.Profile = filename;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can only upload image until 5mb for profile image");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can only upload png or jpeg file for profile image");
                        return View(model);
                    }

                }

                CostumeUser user = new CostumeUser()
                {
                    Profile = model.Profile,
                    Name = model.Name,
                    Lastname = model.Lastname,
                    Fullname = model.Name + " " + model.Lastname,
                    UserName = model.Username,
                    Email = model.Email,
                    PhoneNumber = model.Phone
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    IdentityUserRole<string> userRole = new IdentityUserRole<string>()
                    {
                        RoleId = model.RoleId,
                        UserId = user.Id
                    };
                    _context.UserRoles.Add(userRole);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }



        public async Task<IActionResult> Update(string Id)
        {
            if (Id != null)
            {
                if (await _userManager.FindByIdAsync(Id) != null)
                {
                    CostumeUser user = await _context.costumeUsers.FindAsync(Id);
                    IdentityUserRole<string> role = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == Id);
                    VmUserUpdate model = new VmUserUpdate()
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Lastname = user.Lastname,
                        Username = user.UserName,
                        Email = user.Email,
                        Phone = user.PhoneNumber,
                        RoleId = role.RoleId,
                        Profile = user.Profile,
                        Role = _context.Roles.ToList()
                    };

                    return View(model);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        public IActionResult Update(VmUserUpdate model)
        {
            model.Role = _context.Roles.ToList();

            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg")
                    {
                        if (model.ImageFile.Length <= 5242880)
                        {
                            string oldProfile = Path.Combine("wwwroot", "assets/img/profiles", _context.costumeUsers.Find(model.Id).Profile);
                            if (System.IO.File.Exists(oldProfile))
                            {
                                System.IO.File.Delete(oldProfile);
                            }
                            string filename = Guid.NewGuid() + "-" + model.ImageFile.FileName;
                            string filepath = Path.Combine("wwwroot", "assets/img/profiles", filename);
                            using (var stream = new FileStream(filepath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }
                            model.Profile = filename;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can only upload image until 5mb for profile image");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can only upload png or jpeg file for profile image");
                        return View(model);
                    }
                }

                if (_context.costumeUsers.Any(cs => cs.UserName == model.Username))
                {
                    if (_context.costumeUsers.FirstOrDefault(cs => cs.UserName == model.Username).Id != model.Id)
                    {
                        ModelState.AddModelError("", "Username exist in Users List");
                        return View(model);
                    }
                }

                CostumeUser user = _context.costumeUsers.Find(model.Id);
                user.Name = model.Name;
                user.Lastname = model.Lastname;
                user.Fullname = model.Name + " " + model.Lastname;
                user.UserName = model.Username;
                user.Email = model.Email;
                user.PhoneNumber = model.Phone;
                user.Profile = model.Profile;
                _context.SaveChanges();


                IdentityUserRole<string> userRole = new IdentityUserRole<string>()
                {
                    UserId = model.Id,
                    RoleId = model.RoleId
                };
                _context.UserRoles.Remove(_context.UserRoles.FirstOrDefault(ur => ur.UserId == model.Id));
                _context.UserRoles.Add(userRole);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(model);
            }
        }


        public async Task<IActionResult> Delete(string Id)
        {
            if (Id != null)
            {
                if (_context.costumeUsers.Any(u => u.Id == Id))
                {
                    CostumeUser user = _context.costumeUsers.Find(Id);
                    if (user.Profile != null)
                    {
                        string oldProfile = Path.Combine("wwwroot", "assets/img/profiles", user.Profile);
                        if (System.IO.File.Exists(oldProfile))
                        {
                            System.IO.File.Delete(oldProfile);
                        }
                    }
                    _context.UserRoles.Remove(_context.UserRoles.FirstOrDefault(ur => ur.UserId == Id));
                    _context.SaveChanges();
                    await _userManager.DeleteAsync(user);
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(VmUserLogin model)
        {
            if (ModelState.IsValid)
            {
               var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
                if (result.Succeeded) return RedirectToAction("Index", "Home");
                else
                {
                    ModelState.AddModelError("", "Login or Passwort is not correct");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }



    }
}
