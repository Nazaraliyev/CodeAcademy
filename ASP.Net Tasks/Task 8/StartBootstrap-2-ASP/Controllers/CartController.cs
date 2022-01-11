using Microsoft.AspNetCore.Mvc;
using StartBootstrap_2_ASP.Data;
using StartBootstrap_2_ASP.Models;
using System.Linq;

namespace StartBootstrap_2_ASP.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(int? Id)
        {
            if(Id != null)
            {
                if (_context.products.Any(p => p.Id == Id))
                {
                    Cart cart = new Cart()
                    {
                        ProductId = _context.products.Find(Id).Id
                    };
                    _context.carts.Add(cart);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound ();
            }
        }
    }
}
