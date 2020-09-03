using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess
{

    public class UserDAL
    {
        private DMDBEntities Db = new DMDBEntities();

        public void AddUser(UserBO userBO)
        {
            User user = new User() {
                UserID = userBO.UserID,
                UserName = userBO.UserName,
                UserAge = userBO.UserAge,
                UserWeight = userBO.UserWeight,
                UserCurrentGlucoseLevel = userBO.UserCurrentGlucoseLevel
            };
            Db.User.Add(user);
            Db.SaveChanges();
        }

        public void AddMeal(MealBO mealBO)
        {
            Meal meal = new Meal(){

                MealId = mealBO.MealId,
                FoodName = mealBO.FoodName,
                FoodType = mealBO.FoodType,
                FoodAmount = mealBO.FoodAmount

            };
            Db.Meals.Add(meal);
            Db.SaveChanges();
        }

    }

}
