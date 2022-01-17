using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Depot.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            Console.WriteLine("slm");
            return View();

        }

        public IActionResult Index()
		{
            return View();
		}


        public IActionResult Create()
		{
            return View();
		}
    }
}
