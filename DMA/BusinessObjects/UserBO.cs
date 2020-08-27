

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjects
{
    public class UserBO
    {
       public int UserID { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage ="User name is Required")]
        public string UserName { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Age is Required")]
        public int? UserAge { get; set; }
        [Display(Name = "Weight")]
        [Required(ErrorMessage = "Weight is Required")]
        public double UserWeight { get; set; }
        [Display(Name = "Current Blood Glucose Level")]
        [Required(ErrorMessage = "Blood Glucose Level is Required")]
        public double UserCurrentGlucoseLevel { get; set; }
    
    }
}
