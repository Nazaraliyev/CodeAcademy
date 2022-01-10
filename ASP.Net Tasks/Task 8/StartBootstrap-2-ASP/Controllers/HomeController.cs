using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartBootstrap_2_ASP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap_2_ASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
