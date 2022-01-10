using Microsoft.AspNetCore.Mvc;
using StartBootstrap_2_ASP.Data;
using StartBootstrap_2_ASP.Models;
using System.Linq;

namespace StartBootstrap_2_ASP.Areas.admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.categories.ToList());
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.categories.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }




        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.categories.ToList().Any(c => c.Id == Id))
                {
                    return View(_context.categories.Find(Id));
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
        public IActionResult Update(Category model)
        {
            if (ModelState.IsValid && model.Name != null)
            {
                _context.categories.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }





        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.categories.ToList().Any(c => c.Id == Id))
                {
                    _context.categories.Remove(_context.categories.Find(Id));
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
