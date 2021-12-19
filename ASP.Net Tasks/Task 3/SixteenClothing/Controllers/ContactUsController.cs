using Microsoft.AspNetCore.Mvc;

namespace SixteenClothing.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
