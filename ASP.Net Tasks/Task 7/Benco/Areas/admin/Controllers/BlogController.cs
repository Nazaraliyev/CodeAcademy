using Benco.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Benco.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.blogs.Include(c => c.Category).Include(tb => tb.tagToBlogs).ThenInclude(t => t.Blog).Include(u => u.CostumeUser)).ToList());
        }
    }
}
