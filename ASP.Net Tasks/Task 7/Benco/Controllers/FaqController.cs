using Microsoft.AspNetCore.Mvc;

namespace Benco.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
