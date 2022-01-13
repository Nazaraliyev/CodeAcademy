using Microsoft.AspNetCore.Mvc;

namespace Depot.Areas.admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
