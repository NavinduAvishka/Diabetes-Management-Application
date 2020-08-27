using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjects
{
    public class MealBO
    {
        public int MealId { get; set; }

        [Display(Name = "Food Name")]
        [Required(ErrorMessage = "Food Name is required")]
        public string FoodName { get; set; }

        [Display(Name = "Food Type")]
        [Required(ErrorMessage = "Food Type is reuqired")]
        public string FoodType { get; set; }

        [Display(Name = "Food Amount (g)")]
        [Required(ErrorMessage = "Food Amount is reuqired")]
        public double FoodAmount { get; set; }
    }
}
