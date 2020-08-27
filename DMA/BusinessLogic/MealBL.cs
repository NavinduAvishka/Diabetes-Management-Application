using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;

namespace BusinessLogic
{
    public class MealBL
    {
        public CustomBO AddMeal(MealBO objMealBo)
        {
            return new MealDAL().AddMeal(objMealBo);
        }
    }
}
