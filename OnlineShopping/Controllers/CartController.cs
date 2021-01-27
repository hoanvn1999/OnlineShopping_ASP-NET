using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class CartController : Controller
    {
        private OnlineShoppingEntities _db = new OnlineShoppingEntities();
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<Cart>();
            if (cart != null)
            {
                list = (List<Cart>)cart;
                ViewBag.products = list;
            }
            return View(list);
        }
        public ActionResult AddItem(int id, string img, string name, double price, int quantity)
        {
            var item = new Cart();
            var cart = Session[CartSession];
            if(cart != null)
            {
                var list = (List<Cart>)cart;
                if (list.Exists(x => x.ProductID == id)){
                    foreach (var i in list)
                    {
                        if (i.ProductID == id)
                        {
                            i.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    item.ProductID = id;
                    item.PruductIMG = img;
                    item.ProductName = name;
                    item.ProductPrice = price;
                    item.Quantity = quantity;
                    list.Add(item);
                }  
            }
            else
            {
                item.ProductID = id;
                item.PruductIMG = img;
                item.ProductName = name;
                item.ProductPrice = price;
                item.Quantity = quantity;
                var list = new List<Cart>();
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
    }
}