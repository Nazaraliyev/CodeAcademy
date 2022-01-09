using Benco.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Benco.Areas.admin.Controllers
{
    [Area("admin")]
    public class RollsController : Controller
    {
        private readonly AppDbContext _context;

        public RollsController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Roles.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(IdentityRole model)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Roles.Any(r => r.Name == model.Name))
                {
                    _context.Roles.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Name exist Roll List");
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
                if (_context.Roles.Any(r => r.Id == Id))
                {
                    return View(_context.Roles.Find(Id));
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
        public IActionResult Update(IdentityRole model)
        {
            if (ModelState.IsValid && model.Name != null)
            {
                _context.Roles.Update(model);
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
                if (_context.Roles.Any(r => r.Id == Id))
                {
                    _context.Roles.Remove(_context.Roles.Find(Id));
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
