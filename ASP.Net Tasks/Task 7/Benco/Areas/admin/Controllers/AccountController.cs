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

        public AccountController(AppDbContext context, IWebHostEnvironment webHostEnvironment ,UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
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
            CostumeUser User = model.CostumeUser; 
            if (ModelState.IsValid)
            {
                if(User.PasswordHash == User.RePassword)
                {
                    if(User.ImageFile == null)
                    {
                        User.Image = "profile.png";
                    }
                    else
                    {
                        if (User.ImageFile.ContentType == "image/jpeg" || User.ImageFile.ContentType == "imge/png" || User.ImageFile.ContentType == "xml/svg")
                        {
                            if(User.ImageFile.Length <= 5242880)
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
                    User.Fullname = User.Name + " " + User.Lastname;
                    User.CreatedTime = DateTime.Now;
                    if (User.UserName == null) User.UserName = User.Email;
                    var result = await _userManager.CreateAsync(User, User.PasswordHash);
                    if (result.Succeeded)
                    {
                        IdentityUserRole<string> userRole = new IdentityUserRole<string>()
                        {
                            UserId = User.Id,
                            RoleId = model.RoleId,
                        };
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
                    ModelState.AddModelError("", "RePassword is not correct");
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
        public IActionResult Update(CostumeUser model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult Delete(string Id)
        {
            if(Id != null)
            {
                if(_context.costumeUsers.ToList().Any(u => u.Id == Id)){
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
