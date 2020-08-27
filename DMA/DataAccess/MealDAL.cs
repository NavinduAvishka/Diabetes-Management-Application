using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class MealDAL
    {
        private DMDBEntities db;

        public MealDAL()
        {
            db = new DMDBEntities();

        }

        public CustomBO AddMeal(MealBO objMealBo)
        {
            CustomBO objCustomBO = new CustomBO();

            Meal objMeal = new Meal()
            {
                FoodName = objMealBo.FoodName,
                FoodType = objMealBo.FoodType,
                FoodAmount = objMealBo.FoodAmount
            };

            db.Meals.Add(objMeal);
            int returnValue = db.SaveChanges();

            if (returnValue > 0)
            {
                objCustomBO.CustomMessage = "Data Successfully Added";
                objCustomBO.CustomMessageNumber = returnValue;
            }
            else
            {
                objCustomBO.CustomMessage = "Problem adding meal details";
                objCustomBO.CustomMessageNumber = returnValue;
            }

            return objCustomBO;
        }

    }
}
