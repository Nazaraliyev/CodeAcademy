using Microsoft.AspNetCore.Mvc;

namespace Repair.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
