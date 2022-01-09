

using Benco.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Benco.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        public IActionResult CheckAccount()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CheckAccount(VmLogin model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }



    }
}
