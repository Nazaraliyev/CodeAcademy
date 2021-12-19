using Microsoft.AspNetCore.Mvc;
using SixteenClothing.Data;
using SixteenClothing.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace SixteenClothing.Controllers
{
    public class OurProductsController : Controller
    {
        private readonly AppDbContext _context;

        public OurProductsController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Product> product = _context.Products.ToList();
            Settings settings =  _context.Settings.FirstOrDefault();

            dynamic model = new ExpandoObject();

            model.settings = settings;
            model.products = product;
            return View(model);
        }
    }
}
