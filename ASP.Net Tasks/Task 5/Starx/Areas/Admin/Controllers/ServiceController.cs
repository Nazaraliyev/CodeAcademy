using Microsoft.AspNetCore.Mvc;

namespace Starx.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
