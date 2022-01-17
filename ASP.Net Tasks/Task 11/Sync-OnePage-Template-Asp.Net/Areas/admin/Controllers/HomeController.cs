using Microsoft.AspNetCore.Mvc;

namespace Sync_OnePage_Template_Asp.Net.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
