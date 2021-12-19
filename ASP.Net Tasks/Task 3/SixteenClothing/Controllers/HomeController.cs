using Microsoft.AspNetCore.Mvc;

namespace SixteenClothing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
