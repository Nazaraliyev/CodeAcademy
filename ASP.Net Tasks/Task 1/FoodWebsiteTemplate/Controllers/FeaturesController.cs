using Microsoft.AspNetCore.Mvc;

namespace FoodWebsiteTemplate.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
