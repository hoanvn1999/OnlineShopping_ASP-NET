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
                OnlineShoppingEntities db = new OnlineShoppingEntities();
                db.USERS.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult PostSignIn()
        {
            return RedirectToRoute("Index", "Home");
        }

        public ActionResult SignOut()
        {
            return RedirectToRoute("Index", "Home");
        }
    }
}