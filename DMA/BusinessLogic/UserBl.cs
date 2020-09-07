using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;

namespace BusinessLogic
{
    public class UserBl
    {
        private DAL userData = new DAL();

        public void AddUser(UserBO userBO)
        {
            new DAL().AddUser(userBO);

        }

        // Getting List<UserBO> type
        public List<UserBO> UserDetails()
        {
            return userData.GetUserDetails(); 
        }

      

    }
}
