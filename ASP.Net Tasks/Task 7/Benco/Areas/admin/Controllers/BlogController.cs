using Benco.Data;
using Benco.Models;
using Benco.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Benco.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.Tag = _context.blogTags.ToList();
            return View(_context.blogs.Include(u => u.CostumeUser).Include(c => c.Category).Include(tb => tb.tagToBlogs).ThenInclude(t => t.BlogTag).ToList());
        }


        public IActionResult Create()
        {
            VmBlogCreate model = new VmBlogCreate()
            {
                blogTag = _context.blogTags.ToList(),
                category = _context.categories.ToList()
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult Create(VmBlogCreate model)
        {
            model.blogTag = _context.blogTags.ToList();
            model.category = _context.categories.ToList();
            if (ModelState.IsValid)
            {
                if (model.blog.CoverFile != null)
                {
                    if (model.blog.CoverFile.ContentType == "image/png" || model.blog.CoverFile.ContentType == "image/jpeg")
                    {
                        string fileName = Guid.NewGuid() + "-" + model.blog.CoverFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/img/blogCover", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.blog.CoverFile.CopyTo(stream);
                        }

                        model.blog.Cover = fileName;
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only Image and Video for Cover");
                        return View(model);
                    }
                }
                else
                {
                    model.blog.Cover = "image.jpg";
                }

                model.blog.CreatedTime = DateTime.Now;
                _context.blogs.Add(model.blog);
                _context.SaveChanges();

                if (model.Tags != null)
                {
                    foreach (var tag in model.Tags)
                    {
                        TagToBlog tagToBlog = new TagToBlog()
                        {
                            BlogId = model.blog.Id,
                            TagId = tag
                        };
                        _context.tagToBlogs.Add(tagToBlog);
                        _context.SaveChanges();
                    }
                }

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
                if (_context.blogs.Any(b => b.Id == Id))
                {

                    List<TagToBlog> tagToBlogs =  _context.tagToBlogs.ToList().FindAll(tb => tb.BlogId == Id);

                    foreach (var tb in tagToBlogs)
                    {
                        _context.tagToBlogs.Remove(tb);
                    }

                    _context.SaveChanges();



                    _context.blogs.Remove(_context.blogs.Find(Id));
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
