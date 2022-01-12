using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleCrud.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;

        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            ViewBag.Rolls = _context.Roles.ToList();
            return View(_context.costumeUsers.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Rolls = new SelectList(_context.Roles.ToList(), "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CostumeUser model)
        {
            ViewBag.Rolls = new SelectList(_context.Roles.ToList(), "Id", "Name");

            if (ModelState.IsValid)
            {
                if (model.Name != null && model.Lastname != null)
                {

                    if (model.PasswordHash != null)
                    {
                        if (model.PasswordHash == model.RePassword)
                        {
                            model.Fullname = model.Name + " " + model.Lastname;
                            if (model.formFile != null)
                            {
                                if (model.formFile.ContentType == "image/jpeg" || model.formFile.ContentType == "image/png")
                                {
                                    if (model.formFile.Length <= 5242880)
                                    {
                                        string filename = Guid.NewGuid() + "-" + model.formFile.FileName;
                                        string filepath = Path.Combine("wwwroot", "areas/admin/img", filename);
                                        using (var stream = new FileStream(filepath, FileMode.Create))
                                        {
                                            model.formFile.CopyTo(stream);
                                        }
                                        model.Image = filename;
                                    }
                                }
                            }
                            else
                            {
                                model.Image = "profile.png";
                            }


                            var result = await _userManager.CreateAsync(model, model.PasswordHash);

                            if (result.Succeeded)
                            {
                                if (model.RollId != null)
                                {
                                    model.RollId = 1;
                                }

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
                        ModelState.AddModelError("", "Password is required");
                        return View(model);
                    }


                }
                else
                {
                    ModelState.AddModelError("", "Name adn Lastname is required");
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

            if (Id != null)
            {
                if (_context.costumeUsers.Any(c => c.Id == Id))
                {
                    ViewBag.Rolls = new SelectList(_context.Roles.ToList(), "Id", "Name");
                    return View(_context.costumeUsers.Find(Id));
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
        public IActionResult Update(CostumeUser model)
        {
            ViewBag.Rolls = new SelectList(_context.Roles.ToList(), "Id", "Name");
            if (ModelState.IsValid)
            {
                if (model.formFile != null)
                {
                    if (model.formFile.ContentType == "image/jpeg" || model.formFile.ContentType == "image/png")
                    {
                        if (model.formFile.Length <= 5242880)
                        {
                            if (model.Image != "profile.png")
                            {
                                string oldImage = Path.Combine("wwwroot", "areas/admin/img", model.Image);
                                if (System.IO.File.Exists(oldImage))
                                {
                                    System.IO.File.Delete(oldImage);
                                }

                            }

                            string filename = Guid.NewGuid() + "-" + model.formFile.FileName;
                            string filepath = Path.Combine("wwwroot", "areas/admin/img", filename);
                            using (var stream = new FileStream(filepath, FileMode.Create))
                            {
                                model.formFile.CopyTo(stream);
                            }
                            model.Image = filename;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can only upload 5mb for Image Size");
                            return View();
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can only upload image filr for profile");
                        return View(model);
                    }
                }
                model.Fullname = model.Name + " " + model.Lastname;
                CostumeUser user = _context.costumeUsers.Find(model.Id);
                user.Name = model.Name;
                user.Lastname = model.Lastname;
                user.Fullname = model.Fullname;
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.Image = model.Image;
                user.NormalizedUserName = model.UserName.ToUpper();
                _context.SaveChanges();
                return RedirectToAction("Index");

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
                if (_context.costumeUsers.Any(c => c.Id == Id))
                {
                    CostumeUser deletedUser = _context.costumeUsers.Find(Id);
                    if (deletedUser.Image != "profile.png" && String.IsNullOrEmpty(deletedUser.Image))
                    {
                        string path = Path.Combine("wwwroot", "areas/admin/img", deletedUser.Image);
                        System.IO.File.Delete(path);
                    };
                    _context.costumeUsers.Remove(deletedUser);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
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
