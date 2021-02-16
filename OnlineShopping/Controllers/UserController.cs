using OnlineShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(USER obj)

        {
            if (ModelState.IsValid)
            {
                OnlineShoppingEntities _db = new OnlineShoppingEntities();
                _db.USERS.Add(obj);
                _db.SaveChanges();
            }
            ViewBag.message = "User has been created. Please login to use system.";
            return RedirectToAction("SignIn");
        }

        public ActionResult SignIn()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(USER obj)
        {
            if (Request.Cookies["USER"] != null)
            {
                Response.Cookies["USER"].Expires = DateTime.Now.AddDays(-1);
            }
            OnlineShoppingEntities _db = new OnlineShoppingEntities();
            if((from s in _db.USERS where s.EMAIL == obj.EMAIL where s.PASSWORD == obj.PASSWORD select s).ToList().Count > 0)
            {
                string email = obj.EMAIL;
                HttpCookie user = new HttpCookie("USER");
                user["email"] = obj.EMAIL;
                Response.Cookies.Add(user);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.message = "Wrong email or password!";
                return View(obj);
            }
        }

        public ActionResult SignOut()
        {
            if (Request.Cookies["USER"] != null)
            {
                Response.Cookies["USER"].Expires = DateTime.Now.AddDays(-1);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}