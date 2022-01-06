using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Models;
using System.Linq;

namespace SimpleCrud.Areas.admin.Controllers
{
    [Area("admin")]
    public class PositionController : Controller
    {
		private readonly AppDbContext _context;

		public PositionController(AppDbContext context)
		{
			_context = context;
		}
        public IActionResult Index()
        {
            return View(_context.position.ToList());
        }


        public IActionResult Create()
		{
            return View();
		}


        [HttpPost]
        public IActionResult Create(Position model)
        {
            if (ModelState.IsValid && model.Name != null)
			{
                _context.position.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
			}
			else
			{
                return View(model);
			}
            
        }

        public IActionResult Update(int Id)
		{
            return View(_context.position.Find(Id));
		}

        [HttpPost]
        public IActionResult Update(Position model)
		{
			if (ModelState.IsValid)
			{
                _context.position.Update(model);
                _context.SaveChanges();
                return RedirectToAction("index");
			}
			else
			{
                return View(model);
			}
		}

        public IActionResult Delete(int Id)
		{
            _context.position.Remove(_context.position.Find(Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
		}
    }
}
