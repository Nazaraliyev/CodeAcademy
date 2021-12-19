using Microsoft.AspNetCore.Mvc;
using SixteenClothing.Data;
using SixteenClothing.Models;
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
            List<Product> products = _context.Products.ToList();
            List<HomeBanners> banner = _context.HomeBanners.ToList();
            dynamic model = new ExpandoObject();
            model.Banner = banner;
            model.Product = products;
            return View(model);
        }
    }
}
