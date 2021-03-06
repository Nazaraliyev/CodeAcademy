using Benco.Data;
using Benco.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Benco.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogTagController : Controller
    {
        private readonly AppDbContext _context;

        public BlogTagController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.blogTags.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(BlogTag model)
        {
            if (ModelState.IsValid)
            {
                if (!_context.blogTags.ToList().Any(t => t.Name == model.Name))
                {
                    _context.blogTags.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Name exist Tag List");
                    return View(model);
                }
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
                if (_context.blogTags.ToList().Any(t => t.Id == Id))
                {
                    return View(_context.blogTags.Find(Id));
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
        public IActionResult Update(BlogTag model)
        {
            if (ModelState.IsValid && model.Name != null)
            {
                _context.blogTags.Update(model);
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
                if (_context.blogTags.ToList().Any(t => t.Id == Id))
                {
                    _context.blogTags.Remove(_context.blogTags.Find(Id));
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
