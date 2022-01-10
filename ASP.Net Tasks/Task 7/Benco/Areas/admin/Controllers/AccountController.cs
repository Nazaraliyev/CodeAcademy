using Benco.Data;
using Benco.Models;
using Benco.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, IWebHostEnvironment webHostEnvironment, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            ViewBag.Roles = _context.Roles.ToList();
            ViewBag.UserRoles = _context.UserRoles.ToList();
            return View(_context.costumeUsers.ToList());
        }


        public IActionResult Create()
        {
            ViewBag.Roles = _context.Roles.ToList();
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(VmUserRegister model)
        {
            ViewBag.Roles = _context.Roles.ToList();
            CostumeUser User = model.CostumeUser;
            if (ModelState.IsValid)
            {
                if (User.Email != null)
                {

                    if (!String.IsNullOrEmpty(User.PasswordHash))
                    {
                        if (User.PasswordHash == User.RePassword)
                        {
                            if (User.ImageFile != null)
                            {

                                if (User.ImageFile.ContentType == "image/jpeg" || User.ImageFile.ContentType == "imge/png" || User.ImageFile.ContentType == "xml/svg")
                                {
                                    if (User.ImageFile.Length <= 5242880)
                                    {
                                        string fileName = Guid.NewGuid() + "-" + User.ImageFile.FileName;
                                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/profiles", fileName);

                                        using (var stream = new FileStream(filePath, FileMode.Create))
                                        {
                                            User.ImageFile.CopyTo(stream);
                                        }

                                        User.Image = fileName;
                                    }
                                    else
                                    {
                                        ModelState.AddModelError("", "Your file is over 5 MB");
                                        return View(model);
                                    }
                                }
                                else
                                {
                                    ModelState.AddModelError("", "File is not Image File");
                                    return View(model);
                                }
                            }
                            else
                            {
                                User.Image = "profile.png";
                            }

                            if (User.UserName != null)
                            {
                                if (_context.costumeUsers.Any(u => u.UserName == User.UserName))
                                {
                                    ModelState.AddModelError("", "You can not use this Username");
                                    return View(model);
                                }
                            }
                            else
                            {
                                if (_context.costumeUsers.Any(u => u.UserName == User.Email))
                                {
                                    ModelState.AddModelError("", "This Mail use for Username, change Email or username");
                                    return View(model);
                                }
                                else
                                {
                                    User.UserName = User.Email;
                                }
                            }

                            User.Fullname = User.Name + " " + User.Lastname;
                            User.CreatedTime = DateTime.Now;


                            var result = await _userManager.CreateAsync(User, User.PasswordHash);


                            IdentityUserRole<string> userRole = new IdentityUserRole<string>();


                            if (result.Succeeded)
                            {
                                if (model.RoleId == null)
                                {
                                    userRole.UserId = User.Id;
                                    userRole.RoleId = _context.Roles.FirstOrDefault(r => r.Name == "Not Choose").Id;
                                }
                                else
                                {
                                    userRole.UserId = User.Id;
                                    userRole.RoleId = model.RoleId;
                                }
                                _context.UserRoles.Add(userRole);
                                _context.SaveChanges();
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                return View(model);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("", "RePassword is not Correct");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password can not be Null");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email can not be null");
                    return View(model);
                }

            }
            else
            {
                return View(model);

            }
        }


        public IActionResult Update(string Id)
        {
            VmUserRegister model = new VmUserRegister()
            {
                CostumeUser = _context.costumeUsers.Find(Id),
                RoleId = _context.UserRoles.FirstOrDefault(u => u.UserId == _context.costumeUsers.Find(Id).Id).RoleId
            };
            ViewBag.Roles = _context.Roles.ToList();
            return View(model);
        }


        [HttpPost]
        public IActionResult Update(VmUserRegister model)
        {
            ViewBag.Roles = _context.Roles.ToList();
            CostumeUser user = model.CostumeUser;
            if (ModelState.IsValid)
            {
                if (user.ImageFile != null)
                {
                    if (user.Image != "profile.png")
                    {
                        string oldImage = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/profiles", user.Image);
                        if (System.IO.File.Exists(oldImage))
                        {
                            System.IO.File.Delete(oldImage);
                        }
                    }

                    string fileName = Guid.NewGuid() + "-" + user.ImageFile.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/profiles", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        user.ImageFile.CopyTo(stream);
                    }

                    user.Image = fileName;
                }

                if (model.RoleId != null)
                {
                    if (_context.Roles.Any(r => r.Id == model.RoleId))
                    {
                        _context.UserRoles.Remove(_context.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id));
                        IdentityUserRole<string> userRole = new IdentityUserRole<string>()
                        {
                            UserId = user.Id,
                            RoleId = model.RoleId
                        };
                        _context.UserRoles.Add(userRole);
                        _context.SaveChanges();
                    }
                }

                if (user.UserName != null)
                {
                    if (_context.costumeUsers.Any(u => u.UserName == user.UserName))
                    {
                        if (_context.costumeUsers.FirstOrDefault(u => u.UserName == user.UserName).Id != user.Id)
                        {
                            ModelState.AddModelError("", "You can not use this Username");
                            return View(model);
                        }
                    }
                }
                else
                {
                    if (_context.costumeUsers.Any(u => u.UserName == user.Email))
                    {
                        if(_context.costumeUsers.FirstOrDefault(u => u.UserName == user.Email).Id != user.Id)
                        {
                            ModelState.AddModelError("", "This Email use for Username, Change Email or Username");
                            return View(model);
                        }
                        else
                        {
                            user.UserName = user.Email;
                        }
                    }
                }
                user.Fullname = user.Name + " " + user.Lastname;


                CostumeUser updatedUser = _context.costumeUsers.Find(user.Id);
                updatedUser.Image = user.Image;
                updatedUser.Name = user.Name;
                updatedUser.Lastname = user.Lastname;
                updatedUser.Fullname = user.Fullname;
                updatedUser.UserName = user.UserName;
                updatedUser.NormalizedEmail = user.UserName.ToUpper();
                updatedUser.PhoneNumber = user.PhoneNumber;
                updatedUser.Email = user.Email;
                updatedUser.CreatedTime = user.CreatedTime;
                _context.SaveChanges();
                return RedirectToAction("index");

            }
            else
            {
                return View(model);
            }
        }


        public IActionResult Delete(string Id)
        {
            if (Id != null)
            {
                if (_context.costumeUsers.ToList().Any(u => u.Id == Id))
                {
                    _context.costumeUsers.Remove(_context.costumeUsers.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("index");
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

    }
}
