using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixteenClothing.Data;
using SixteenClothing.ViewModel;
using System.Linq;

namespace SixteenClothing.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;

        public AboutUsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAboutUs model = new VmAboutUs()
            {
                teams = _context.TeamMembers.Include("Speciality").ToList(),
                qualities = _context.Qualities.ToList(),
                partners = _context.Partners.ToList(),
                settings = _context.Settings.FirstOrDefault()
            };
            return View(model);
        }
    }
}
