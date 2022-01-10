using Microsoft.AspNetCore.Mvc;
using StartBootstrap_2_ASP.Data;
using StartBootstrap_2_ASP.Models;

namespace StartBootstrap_2_ASP.Areas.admin.Controllers
{
    [Area("admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
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
