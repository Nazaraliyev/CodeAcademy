using Microsoft.AspNetCore.Mvc;
using Starx.Areas.Admin.ViewModel;
using Starx.Data;
using Starx.Models;
using System.Collections.Generic;
using System.Linq;

namespace Starx.Areas.Admin.Controllers
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
            VmCategory model = new VmCategory()
            {
                categories = _context.categories.ToList()
            };
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(VmCategory model)
        {
            _context.categories.Add(model.category);
            _context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult Delete(int Id)
        {
            Category FindCategory = _context.categories.FirstOrDefault(e => e.Id == Id);
            _context.categories.Remove(FindCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int Id)
        {
            Category FindCategory = _context.categories.FirstOrDefault(e => e.Id == Id);
            VmCategory model = new VmCategory()
            {
                categories = _context.categories.ToList(),
                category = FindCategory
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult Update(VmCategory model)
        {
            _context.categories.FirstOrDefault(e => e.Id == model.category.Id).Name = model.category.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
