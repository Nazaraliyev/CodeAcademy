using Microsoft.AspNetCore.Mvc;

namespace SimpleCrud.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
