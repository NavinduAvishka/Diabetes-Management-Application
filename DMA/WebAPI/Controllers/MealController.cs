using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
namespace WebAPI.Controllers
{
    public class MealController : Controller
    {
        // GET: Meal
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MealBO mealBO)
        {
            if (ModelState.IsValid)
            {
                MealBl mealBl = new MealBl();
                mealBl.AddMeal(mealBO);
                return RedirectToAction("Index");

            }

            return View(mealBO);

        }


    }
}