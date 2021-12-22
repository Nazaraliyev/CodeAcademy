using Microsoft.AspNetCore.Mvc;
using SixteenClothing.Data;
using SixteenClothing.Models;
using SixteenClothing.ViewModel;
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
            VmOurProduct model = new VmOurProduct()
            {
                product = _context.Products.Take(6).ToList(),
                settings = _context.Settings.FirstOrDefault(),
            };
            return View(model);
        }
    }
}
