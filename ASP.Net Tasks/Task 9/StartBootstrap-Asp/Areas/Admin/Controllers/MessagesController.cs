using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using StartBootstrap_Asp.ViewModel;
using System.Linq;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class MessagesController : Controller
    {
        private readonly AppDbContext _context;

        public MessagesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.contactMessages.ToList());
        }  

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else if(_context.contactMessages.Any(m => m.Id == Id))
            {
                _context.contactMessages.Remove(_context.contactMessages.FirstOrDefault(m => m.Id == Id));
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

    }
}
