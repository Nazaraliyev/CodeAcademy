using Microsoft.AspNetCore.Mvc;
using Simple_API.Data;
using System.Linq;

namespace Simple_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class FakultyController : Controller
    {
        private readonly AppDbContext _context;

        public FakultyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_context.faculties.ToList());
        }
    }
}
