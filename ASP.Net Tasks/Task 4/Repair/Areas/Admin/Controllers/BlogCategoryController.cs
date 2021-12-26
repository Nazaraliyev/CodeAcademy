using Microsoft.AspNetCore.Mvc;
using Repair.Areas.Admin.ViewModel;
using Repair.Data;
using Repair.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repair.Areas.Admin.Controllers
{
    [Area("admin")]
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BlogCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBlogCategory model = new VmBlogCategory()
            {
                blogCategories = _context.blogCategories.ToList(),
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult Create(VmBlogCategory model)

        {
            _context.blogCategories.Add(model.categories);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
