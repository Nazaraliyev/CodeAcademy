using Microsoft.AspNetCore.Mvc;

namespace Repair.Areas.Admin.Controllers
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
