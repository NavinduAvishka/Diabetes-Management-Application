using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessObjects;


namespace WebAPI.Controllers
{
    public class MealController : Controller
    {
        // GET: Meal
        [System.Web.Http.HttpGet]
        public ActionResult Index()
        {
            return View("");
        }

        [HttpPost]
        public ActionResult Index(MealBO objMealBO)
        {
            if (ModelState.IsValid)
            {
                MealBL objMealBL = new MealBL();
                CustomBO objCustomBO = objMealBL.AddMeal(objMealBO);
                return RedirectToAction("Index");
            }
            return View(objMealBO);
        }

    }
}
