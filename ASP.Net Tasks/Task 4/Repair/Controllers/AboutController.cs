using Microsoft.AspNetCore.Mvc;

namespace Repair.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
