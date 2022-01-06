using Microsoft.AspNetCore.Mvc;

namespace Benco.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
