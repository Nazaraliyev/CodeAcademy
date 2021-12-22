using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace SixteenClothing.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddToCart(int id)
        {

            string basket = Request.Cookies["basket"];

            if (!string.IsNullOrEmpty(basket))
            {
                List<string> datalist = basket.Split("-").ToList();

                if (!datalist.Any(element => element == id.ToString()))
                {
                    basket = basket + "-" + id;
                }
                else
                {
                    datalist.Remove(id.ToString());
                    basket = string.Join("-", datalist);
                }

            }
            else
            {
                
                basket = id.ToString();
            }

            Response.Cookies.Append("basket", basket);



            return RedirectToAction("Index", TempData["controller"].ToString());
        }
    }
}
