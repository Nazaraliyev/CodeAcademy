using Microsoft.AspNetCore.Mvc;

namespace SixteenClothing.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
