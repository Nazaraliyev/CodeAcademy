using Microsoft.AspNetCore.Mvc;
using SixteenClothing.Data;
using SixteenClothing.Models;
using SixteenClothing.ViewModel;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace SixteenClothing.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            VmHome model = new VmHome()
            {
                banners = _context.HomeBanners.ToList(),
                products = _context.Products.Take(6).ToList(),
                settings = _context.Settings.FirstOrDefault()
            };



            return View(model);
        }
    }
}
