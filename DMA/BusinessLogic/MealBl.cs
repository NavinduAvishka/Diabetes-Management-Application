using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
  public class MealBl
    {
        private DAL mealData = new DAL();

        public void AddMeal(MealBO mealBO)
        {
            new DAL().AddMeal(mealBO);
            
        }

        // Getting List<MealBO> type
        public List<MealBO> MealDetails()
        {
            return mealData.GetMealDetails();
        }


    }
}
