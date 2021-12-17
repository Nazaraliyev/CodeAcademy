using Microsoft.AspNetCore.Mvc;

namespace FoodWebsiteTemplate.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
