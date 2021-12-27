using Microsoft.AspNetCore.Mvc;
using Starx.Areas.Admin.ViewModel;
using Starx.Data;

namespace Starx.Areas.Admin.Controllers
{
    [Area("admin")]

    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;



        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAuthor
            return View();
        }
    }
}
