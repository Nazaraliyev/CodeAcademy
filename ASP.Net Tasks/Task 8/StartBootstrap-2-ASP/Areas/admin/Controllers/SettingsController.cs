using Microsoft.AspNetCore.Mvc;
using StartBootstrap_2_ASP.Data;
using StartBootstrap_2_ASP.Models;
using System.Linq;

namespace StartBootstrap_2_ASP.Areas.admin.Controllers
{
    [Area("admin")]
    public class SettingsController : Controller
    {
        private readonly AppDbContext _context;

        public SettingsController(AppDbContext context)
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
                _context.settings.Update(model);
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
