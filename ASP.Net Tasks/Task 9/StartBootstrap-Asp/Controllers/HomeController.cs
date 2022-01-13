using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using StartBootstrap_Asp.ViewModel;
using System.Linq;

namespace StartBootstrap_Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmHome model = new VmHome()
            {
                sosialMedia = _context.sosialMedias.ToList(),
                portfolios = _context.portfolios.Take(6).ToList(),
                settings = _context.settings.FirstOrDefault(),
                contactMessage = new ContactMessage()

            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Send(VmHome model)
        {
            ContactMessage message = model.contactMessage;
            if (message.FullName != null && message.Email != null && message.Phone != null && message.Message != null)
            {
                _context.contactMessages.Add(message);
                _context.SaveChanges();
                if(TempData["message"] != null)
                {
                    TempData["message"] = null;
                }
                return RedirectToAction("Index");
            }
            else
            {
                TempData["message"] = "All Boxes is required";
                return RedirectToAction("Index");
            }
        }

    }
}
