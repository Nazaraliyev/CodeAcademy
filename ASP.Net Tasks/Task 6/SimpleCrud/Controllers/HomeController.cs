using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCrud.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Controllers
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
            return View(_context.employees.ToList());
        }

        public IActionResult Create()
		{
            return View();
		}

    }
}
