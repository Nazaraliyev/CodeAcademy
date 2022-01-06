using Microsoft.AspNetCore.Mvc;

namespace Benco.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
