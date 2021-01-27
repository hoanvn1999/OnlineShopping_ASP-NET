using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Views.Shared
{
    public class CategoryController : Controller
    {
        private OnlineShoppingEntities _db = new OnlineShoppingEntities();
        // GET: Category
        [ChildActionOnly]
        public ActionResult NavBar()
        {
            var category = _db.CATEGORIES.ToList();
            ViewBag.categories = category;
            return PartialView("_NavBar", category);
        }
    }
}