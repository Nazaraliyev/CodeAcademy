using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCrud.Models;
using System.Linq;

namespace SimpleCrud.Areas.admin.Controllers
{
    [Area("admin")]
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.employees.Include(x => x.position).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Position = _context.position.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                model.FullName = model.Name + " " + model.LastName;
                _context.employees.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            else
            {
                return View(model);
            }

        }

        public IActionResult Update(int id)
        {
            ViewBag.Positions = _context.position.ToList();
            return View(_context.employees.Find(id));
        }


        [HttpPost]
        public IActionResult Update(Employee model)
        {
            if (ModelState.IsValid)
            {
                model.FullName = model.Name + " " + model.LastName;
                _context.employees.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }




        public IActionResult Delete(int Id)
        {
            _context.employees.Remove(_context.employees.Find(Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
