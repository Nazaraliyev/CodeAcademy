using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Repair.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("admin")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
