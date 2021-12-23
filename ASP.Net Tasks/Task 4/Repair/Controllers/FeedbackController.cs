using Microsoft.AspNetCore.Mvc;

namespace Repair.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
