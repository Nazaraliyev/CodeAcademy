using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace SixteenClothing.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToCart(int id)
        {

            string basket = Request.Cookies["basket"];

            if (!string.IsNullOrEmpty(basket))
            {
                List<string> datalist = basket.Split("-").ToList();

                if(!datalist.Any(element => element == id.ToString()))
                {
                    basket = basket + "-" + id;
                }

            }
            else
            {
                basket = id.ToString();
            }

            Response.Cookies.Append("basket", basket);



            return RedirectToAction("Index", "Home") ;
        }
    }
}
