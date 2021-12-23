using Microsoft.AspNetCore.Mvc;

namespace Repair.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
