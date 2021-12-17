using Microsoft.AspNetCore.Mvc;

namespace FoodWebsiteTemplate.Controllers
{
    public class BlogDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
