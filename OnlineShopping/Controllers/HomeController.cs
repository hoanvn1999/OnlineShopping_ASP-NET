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
            int category = Convert.ToInt16(Request.QueryString["cat"]);
            var product = _db.PRODUCTS.ToList();
            if (category != 0)
                product = (from s in _db.PRODUCTS where s.CATEGORY_ID == category select s).ToList();
            ViewBag.products = product;
            return View();
        }

        public ActionResult Product()
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            var product = (from s in _db.PRODUCTS where s.ID == id select s).ToList();
            ViewBag.product = product;
            return View();
        }
    }
}