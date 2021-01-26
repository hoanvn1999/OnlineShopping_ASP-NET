using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        private OnlineShoppingEntities _db = new OnlineShoppingEntities();

        public ActionResult Index()
        {
            var product = _db.PRODUCTS.ToList();
            ViewBag.products = product;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}