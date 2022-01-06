using Microsoft.AspNetCore.Mvc;

namespace Benco.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
