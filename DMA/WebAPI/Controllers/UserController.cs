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
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserBO userBO)
        {
            if (ModelState.IsValid)
            {
                UserBl userBl = new UserBl();
                Custom custom = userBl.AddUser(userBO);
                return RedirectToAction("Index");
            }

            return View(userBO);

        }
    }
}