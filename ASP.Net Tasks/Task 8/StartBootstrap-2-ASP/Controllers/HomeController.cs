using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartBootstrap_2_ASP.Data;
using StartBootstrap_2_ASP.Models;
using StartBootstrap_2_ASP.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap_2_ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmHome model = new VmHome()
            {
                settings = _context.settings.FirstOrDefault(),
                product = _context.products.ToList(),
                CartCount = _context.carts.Count()
            };
            return View(model);
        }
    }
}
