using Microsoft.AspNetCore.Mvc;
using SixteenClothing.Data;
using SixteenClothing.ViewModel;
using System.Linq;

namespace SixteenClothing.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly AppDbContext _context;

        public ContactUsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmContactUs model = new VmContactUs()
            {
                Sosials = _context.SosialMedias.ToList(),
                settings = _context.Settings.FirstOrDefault(),
                partners = _context.Partners.ToList(),
            };

            return View(model);
        }
    }
}
