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
        public void AddMeal(MealBO mealBO)
        {
            new UserDAL().AddMeal(mealBO);
        }
    }
}
