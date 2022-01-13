using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using System;
using System.IO;
using System.Linq;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PortfolioController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.portfolios.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Portfolio model)
        {
            if (model.ImgFile != null)
            {
                if ((model.ImgFile.ContentType == "image/jpeg" || model.ImgFile.ContentType == "image/png"))
                {
                    if (model.ImgFile.Length <= 3145728)
                    {
                        string fileName = Guid.NewGuid() + "-" + model.ImgFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/Img/portfolio", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImgFile.CopyTo(stream);
                        }
                        model.ImgName = fileName;
                        _context.portfolios.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "File Size is over 3mb");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "This is not Image File");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Image is requared");
                return View(model);
            }
        }


        public IActionResult Update(int Id)
        {
            return View(_context.portfolios.First(p => p.Id == Id));
        }




        [HttpPost]
        public IActionResult Update(Portfolio model)
        {
            Portfolio oldPortfolio = _context.portfolios.FirstOrDefault(p => p.Id == model.Id);
            if (ModelState.IsValid)
            {
                if (model.ImgFile != null)
                {
                    if ((model.ImgFile.ContentType == "image/jpeg" || model.ImgFile.ContentType == "image/png"))
                    {
                        if (model.ImgFile.Length <= 3145728)
                        {
                            string oldImg = Path.Combine(_webHostEnvironment.WebRootPath, "assets/Img/portfolio", oldPortfolio.ImgName);
                            if (System.IO.File.Exists(oldImg))
                            {
                                System.IO.File.Delete(oldImg);
                            }

                            string fileName = Guid.NewGuid() + "-" + model.ImgFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/Img/portfolio", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImgFile.CopyTo(stream);
                            }


                            model.ImgName = fileName;
                        }
                        else
                        {
                            ModelState.AddModelError("", "File Size is over 3mb");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "This is not Image File");
                        return View(model);
                    }
                }
                else
                {
                    model.ImgName = oldPortfolio.ImgName;
                }

                //oldPortfolio.ImgDescription = model.ImgDescription;
                Portfolio updated = _context.portfolios.FirstOrDefault(p => p.Id == model.Id);
                updated.ImgName = model.ImgName;
                updated.ImgDescription = model.ImgDescription;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            _context.portfolios.Remove(_context.portfolios.FirstOrDefault(p => p.Id == Id));
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
