using Microsoft.AspNetCore.Mvc;
using Ndumis_Dresses.Helpers;
using Ndumis_Dresses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ndumis_Dresses.Controllers
{
    public class CheckOutController : Controller
    {
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);

            ViewBag.total = Math.Round(ViewBag.total, 2);
            return View();
        }
    }
}
