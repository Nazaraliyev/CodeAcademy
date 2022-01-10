using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap_2_ASP.Areas.admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
