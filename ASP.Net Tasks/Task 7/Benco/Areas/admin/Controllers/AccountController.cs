using Benco.Data;
using Benco.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Benco.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.costumeUsers.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(CostumeUser model)
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


        public IActionResult Update(int Id)
        {
            return View(_context.costumeUsers.Find(Id));
        }


        [HttpPost]
        public IActionResult Update(CostumeUser model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult Delete(string Id)
        {
            if(Id != null)
            {
                if(_context.costumeUsers.ToList().Any(u => u.Id == Id)){
                    _context.costumeUsers.Remove(_context.costumeUsers.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }

    }
}
