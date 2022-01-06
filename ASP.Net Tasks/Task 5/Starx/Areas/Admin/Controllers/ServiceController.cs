using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Starx.Data;
using Starx.Models;
using System;
using System.IO;
using System.Linq;

namespace Starx.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ServiceController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {

            return View(_context.services.Include("Author").ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Author = _context.authors.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service model)
        {

            string fileName = Guid.NewGuid() + "-" + model.ImageFile.FileName;
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                model.ImageFile.CopyTo(stream);
            }

            model.CoverImg = fileName;
            model.CreateTime = DateTime.Now;
            _context.services.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int Id)
        {
            _context.services.Remove(_context.services.FirstOrDefault(e => e.Id == Id));
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        public IActionResult Update(int Id)
        {
            ViewBag.Author = _context.authors.ToList();
            return View(_context.services.Include(a => a.Author).FirstOrDefault(e => e.Id ==  Id));
        }



        [HttpPost]
        public IActionResult Update(Service model)
        {
            _context.services.Update(model);   
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

