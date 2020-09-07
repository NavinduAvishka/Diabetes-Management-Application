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
        public ActionResult AddMeal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMeal(MealBO mealBO)
        {
            if (ModelState.IsValid)
            {
                MealBl mealBl = new MealBl();
                mealBl.AddMeal(mealBO);
                return RedirectToAction("AddMeal");

            }
            return View(mealBO);
        }

        // Meal list view
        [HttpGet]
        public ActionResult MealDetails()
        {
            MealBl mealBl = new MealBl();
            return View(mealBl.MealDetails());
        }


    }
}