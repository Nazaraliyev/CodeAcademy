using Microsoft.AspNetCore.Mvc;

namespace SixteenClothing.Controllers
{
    public class OurProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
