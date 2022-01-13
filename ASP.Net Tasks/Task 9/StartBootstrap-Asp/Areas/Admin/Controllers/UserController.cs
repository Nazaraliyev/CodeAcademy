using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(_context.costumeUsers.ToList());
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CostumeUser model)
        {
            if (ModelState.IsValid && model.PasswordHash != null && model.Email != null)
            {
                if (model.PasswordHash == model.RePassword)
                {
                    model.FullName = model.Name + " " + model.LastName;
                    var result = await _userManager.CreateAsync(model, model.PasswordHash);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("index");
                    }
                    else
                    {
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "RePassword is not True");
                    return View(model);
                }

            }
            else
            {
                return View();
            }
        }


        public IActionResult Update(string Id)
        {
            if (Id != null)
            {
                if (_context.costumeUsers.Any(u => u.Id == Id))
                {
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
            if (ModelState.IsValid && model.Email != null && model.UserName != null)
            {
                CostumeUser user = _context.costumeUsers.Find(model.Id);
                user.Name = model.Name;
                user.LastName = model.LastName;
                user.FullName = model.Name + " " + model.LastName;
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.NormalizedUserName = model.UserName.ToUpper();
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult UpdatePassWord(string Id)
        {
            if (Id != null)
            {
                if (_context.costumeUsers.Any(u => u.Id == Id))
                {
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

        //[HttpPost] 
        //public IActionResult UpdatePassWord(CostumeUser model)
        //{
        //    CostumeUser oldUser = _context.costumeUsers.Find(model.Id);
        //    if (model.PasswordHash != null)
        //    {
        //        if(oldUser)
        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}


        public IActionResult Delete(string Id)
        {
            if (Id != null)
            {
                if (_context.costumeUsers.Any(u => u.Id == Id))
                {
                    _context.costumeUsers.Remove(_context.costumeUsers.Find(Id));
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
