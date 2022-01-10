using Microsoft.AspNetCore.Mvc;
using StartBootstrap_2_ASP.Data;
using System.Linq;

namespace StartBootstrap_2_ASP.Areas.admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.categories.ToList());
        }
    }
}
