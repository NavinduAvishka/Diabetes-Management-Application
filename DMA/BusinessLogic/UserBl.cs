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
        public void AddUser(UserBO userBO)
        {
            new UserDAL().AddUser(userBO);

        }

      

    }
}
