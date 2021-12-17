using Microsoft.AspNetCore.Mvc;

namespace FoodWebsiteTemplate.Controllers
{
    public class BlogGridController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
