using Microsoft.AspNetCore.Mvc;
using Starx.Areas.Admin.ViewModel;
using Starx.Data;
using Starx.Models;
using System.Linq;

namespace Starx.Areas.Admin.Controllers
{
    [Area("admin")]

    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;



        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAuthor model = new VmAuthor()
            {
                authors = _context.authors.ToList(),
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(VmAuthor model)
        {
            _context.authors.Add(model.author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int Id)
        {
            // Version 1
            //Author FoundAuthor = _context.authors.FirstOrDefault(e => e.Id == Id);
            //_context.authors.Remove(FoundAuthor);


            //Version 2
            _context.authors.Remove(_context.authors.FirstOrDefault(e => e.Id == Id));

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int Id)
        {
            VmAuthor model = new VmAuthor()
            {
                authors = _context.authors.ToList(),
                update = _context.authors.FirstOrDefault(e => e.Id == Id)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(VmAuthor model)
        {
            Author UpdatedAuthor = model.update;
            _context.authors.FirstOrDefault(e => e.Id == UpdatedAuthor.Id).Name = UpdatedAuthor.Name;
            _context.authors.FirstOrDefault(e => e.Id == UpdatedAuthor.Id).Surname = UpdatedAuthor.Surname;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
