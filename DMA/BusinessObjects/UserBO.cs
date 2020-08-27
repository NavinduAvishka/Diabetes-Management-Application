

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class UserBO
    {
       public int UserID { get; set; }
        public string UserName { get; set; }
        public int? UserAge { get; set; }
        public double UserWeight { get; set; }
        public double UserCurrentGlucoseLevel { get; set; }
    
        //public virtual MonthlyInput MonthlyInput { get; set; }
    }
}
