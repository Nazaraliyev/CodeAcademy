using Microsoft.AspNetCore.Mvc;

namespace Starx.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
