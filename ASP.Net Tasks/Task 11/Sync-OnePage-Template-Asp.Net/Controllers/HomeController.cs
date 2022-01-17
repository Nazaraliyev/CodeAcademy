using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sync_OnePage_Template_Asp.Net.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_OnePage_Template_Asp.Net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
