using Microsoft.AspNetCore.Mvc;

namespace Starx.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("admin")]


        public IActionResult Index()
        {
            return View();
        }
    }
}
