using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repair.Data;
using Repair.Models;
using System.Linq;

namespace Repair.Areas.Admin.Controllers
{
    [Area("admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.blogs.Include("BlogCategory").ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.blogCategories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (ModelState.IsValid)
            {
                //if (model.formFile.ContentType == "image/jpeg" || )
            }
            else
            {
                return View(model);
            }
            ViewBag.Categories = _context.blogCategories.ToList();
            return View();
        }
    }
}
