using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessObjects;


namespace WebAPI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddUser()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserBO userBO)
        {
            if (ModelState.IsValid)
            {
                UserBl userBl = new UserBl();
                userBl.AddUser(userBO);
                return RedirectToAction("AddUser");
            }

            return View(userBO);

        }

        // User's list view
        [HttpGet]
        public ActionResult UserDetails()
        {
            UserBl userBl = new UserBl();
            return View(userBl.UserDetails());
        }

    }
}
