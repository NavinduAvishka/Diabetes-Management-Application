using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess
{

    public class DAL
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
            Db.Users.Add(user);
            Db.SaveChanges();
        }


        /// <summary>
        /// Gets the user details.
        /// </summary>
        /// returns a list of "List<UserBO> type
        public List<UserBO> GetUserDetails()
        {
            List<UserBO> userBoList = new List<UserBO>();

            List<User> userList = Db.Users.ToList();

            foreach(User item in userList)
            {
                UserBO userBo = new UserBO();
                userBo.UserID = item.UserID;
                userBo.UserName = item.UserName;
                userBo.UserAge = item.UserAge;
                userBo.UserWeight = item.UserWeight;
                userBo.UserCurrentGlucoseLevel = item.UserCurrentGlucoseLevel;
                userBoList.Add(userBo);
            }
            return userBoList;
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

        /// <summary>
        /// Gets the meal details.
        /// </summary>
        /// returns a list of "List<MealBO> type
        public List<MealBO> GetMealDetails()
        {
            List<MealBO> mealBoList = new List<MealBO>();

            List<Meal> mealList = Db.Meals.ToList();

            foreach (Meal item in mealList)
            {
                MealBO mealBo = new MealBO();
                mealBo.MealId = item.MealId;
                mealBo.FoodName = item.FoodName;
                mealBo.FoodType = item.FoodType;
                mealBo.FoodAmount = item.FoodAmount;
                mealBoList.Add(mealBo);
                
            }
            return mealBoList;
        }

    }

}
