using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StartBootstrap_2_ASP.Data;
using StartBootstrap_2_ASP.Models;
using System;
using System.IO;
using System.Linq;

namespace StartBootstrap_2_ASP.Areas.admin.Controllers
{
    [Area("admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.products.Include(c => c.Category).ToList());
        }


        public IActionResult Create()
        {
            ViewBag.Category = _context.categories.ToList();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product model)
        {
            ViewBag.Category = _context.categories.ToList();

            if (ModelState.IsValid && model.Name != null)
            {
                if (model.Star != null)
                {
                    if (!(0 < model.Star && model.Star <= 5))
                    {
                        ModelState.AddModelError("", "Star can be change between 1 and 5");
                        return View(model);
                    }
                }
                if (model.ImageFile != null)
                {
                    string filename = Guid.NewGuid() + "-" + model.ImageFile.FileName;
                    string filepath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/product", filename);

                    using (var stream = new FileStream(filepath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }
                    model.Image = filename;
                }
                else
                {
                    ModelState.AddModelError("", "Cover Image is required");
                    return View(model);
                }

                model.CreatedTime = DateTime.Now;
                _context.products.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.products.Any(p => p.Id == Id))
                {
                    ViewBag.Category = _context.categories.ToList();
                    return View(_context.products.Find(Id));
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


        [HttpPost]
        public IActionResult Update(Product model)
        {
            ViewBag.Category = _context.categories.ToList();
            if (ModelState.IsValid)
            {
                if (model.Star != null)
                {
                    if (!(0 < model.Star && model.Star <= 5))
                    {
                        ModelState.AddModelError("", "Star can be change between 1 and 5");
                        return View(model);
                    }
                }
                if (model.ImageFile != null)
                {
                    string oldImage = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/product", model.Image);
                    if (System.IO.File.Exists(oldImage))
                    {
                        System.IO.File.Delete(oldImage);
                    }
                    string filename = Guid.NewGuid() + "-" + model.ImageFile.FileName;
                    string filepath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/product", filename);

                    using (var stream = new FileStream(filepath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }
                    model.Image = filename;
                }

                _context.products.Update(model);
                _context.SaveChanges();
                return RedirectToAction("index");



            }
            else
            {
                return View(model);
            }
        }






        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                if (_context.products.Any(p => p.Id == Id))
                {
                    string oldImage = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/product", _context.products.Find(Id).Image);
                    if (System.IO.File.Exists(oldImage))
                    {
                        System.IO.File.Delete(oldImage);
                    }
                    _context.products.Remove(_context.products.Find(Id));
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
