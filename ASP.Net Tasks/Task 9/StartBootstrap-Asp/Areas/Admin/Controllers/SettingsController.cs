using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using StartBootstrap_Asp.ViewModel;
using System.Linq;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class SettingsController : Controller
    {
        private readonly AppDbContext _context;

        public SettingsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmSettings model = new VmSettings()
            {
                settings = _context.settings.FirstOrDefault(),
                sosialMedias = _context.sosialMedias.ToList(),
            };
            return View(model);
        }

        public IActionResult Update()
        {
            return View(_context.settings.FirstOrDefault());
        }


        [HttpPost]
        public IActionResult Update(Settings model)
        {
            if (model.Location != null && model.Logo != null && model.FreelancerAbout != null)
            {
                Settings settings = _context.settings.FirstOrDefault();
                settings.Logo = model.Logo;
                settings.Location = model.Location;
                settings.FreelancerAbout = model.FreelancerAbout;
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                ModelState.AddModelError("", "All Boxes is Required");
                return View(model);
            }
        }







        public IActionResult SmCreate()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SmCreate(SosialMedia model)
        {
            if (model.Icon != null && model.Name != null && model.Link != null)
            {
                _context.sosialMedias.Add(model);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                ModelState.AddModelError("", "All box is requared");
                return View(model);
            }
        }




        public IActionResult SmUpdate(int Id)
        {
            return View(_context.sosialMedias.FirstOrDefault(s => s.Id == Id));
        }


        [HttpPost]
        public IActionResult SmUpdate(SosialMedia model)
        {
            if (model.Icon != null && model.Name != null && model.Link != null)
            {
                _context.sosialMedias.Update(model);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult SmDelete(int Id)
        {
            _context.sosialMedias.Remove(_context.sosialMedias.FirstOrDefault(s => s.Id == Id));
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
