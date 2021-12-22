using Microsoft.AspNetCore.Mvc;
using SixteenClothing.Data;
using SixteenClothing.Models;
using SixteenClothing.ViewModel;
using System.Collections.Generic;
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
            };

            string basket = Request.Cookies["basket"];
            List<Product> products = _context.Products.ToList();
            if (!string.IsNullOrEmpty(basket))
            {
                List<string> datalist = basket.Split("-").ToList();
                products.ForEach(item =>
                {
                    if(datalist.Any(element => element == item.Id.ToString()))
                    {
                        model.products.Add(item);
                    }
            });
            }
            



            return View(model);
        }
    }
}
