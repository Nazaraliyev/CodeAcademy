using Microsoft.AspNetCore.Mvc;

namespace Benco.Areas.admin.Controllers
{
    public class BlogTagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
