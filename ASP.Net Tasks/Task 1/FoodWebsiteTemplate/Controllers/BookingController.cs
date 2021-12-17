using Microsoft.AspNetCore.Mvc;

namespace FoodWebsiteTemplate.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
