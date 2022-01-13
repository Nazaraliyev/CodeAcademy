using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using System.Linq;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View(_context.settings.FirstOrDefault());
        }

        public IActionResult Update()
        {
            return View(_context.settings.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(Settings model)
        {
            if (ModelState.IsValid)
            {
                _context.settings.FirstOrDefault().AboutText = model.AboutText;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
