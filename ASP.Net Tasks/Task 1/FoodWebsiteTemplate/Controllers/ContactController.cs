using Microsoft.AspNetCore.Mvc;

namespace FoodWebsiteTemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
