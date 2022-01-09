using Benco.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Benco.Areas.admin.Controllers
{
    [Area("admin")]
    public class RollsController : Controller
    {
        private readonly AppDbContext _context;

        public RollsController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Roles.ToList());
        }
    }
}
