﻿using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap_2_ASP.Areas.admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
