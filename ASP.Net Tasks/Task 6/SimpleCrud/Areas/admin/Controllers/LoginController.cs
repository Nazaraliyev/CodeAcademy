using Microsoft.AspNetCore.Mvc;

namespace SimpleCrud.Areas.admin.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
	}
}
