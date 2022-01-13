using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StartBootstrap_Asp.Data;
using StartBootstrap_Asp.Models;
using System;
using System.IO;
using System.Linq;

namespace StartBootstrap_Asp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BannerController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.settings.FirstOrDefault());
        }

        public IActionResult Update()
        {
            return View(_context.settings.FirstOrDefault());
        }


        [HttpPost]
        public IActionResult Update(Settings model)
        {
            Settings oldBanner = _context.settings.FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (model.formFile != null)
                {
                    if ((model.formFile.ContentType == "image/jpeg" || model.formFile.ContentType == "image/png" || model.formFile.ContentType == "image/svg+xml"))
                    {
                        if (model.formFile.Length <= 3145728)
                        {
                            string oldImg = Path.Combine(_webHostEnvironment.WebRootPath, "assets/Img/banner", oldBanner.BannerImg);
                            if (System.IO.File.Exists(oldImg))
                            {
                                System.IO.File.Delete(oldImg);
                            }
                            string fileName = Guid.NewGuid() + "-" + model.formFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/Img/banner", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.formFile.CopyTo(stream);
                            }
                            model.BannerImg = fileName;
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
                    model.BannerImg = oldBanner.BannerImg;
                }

                Settings newBanner = _context.settings.FirstOrDefault();
                newBanner.BannerImg = model.BannerImg;
                newBanner.BannerHeader = model.BannerHeader;
                newBanner.BannerText = model.BannerText;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
    }
}
