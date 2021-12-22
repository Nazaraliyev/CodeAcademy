using Microsoft.AspNetCore.Mvc;
using SixteenClothing.Data;
using SixteenClothing.ViewModel;
using System.Linq;

namespace SixteenClothing.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBasket model = new VmBasket()
            {
                settings = _context.Settings.FirstOrDefault(),
                products = _context.Products.ToList()
            };
            return View(model);
        }
    }
}
