using Microsoft.AspNetCore.Mvc;

namespace Benco.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
