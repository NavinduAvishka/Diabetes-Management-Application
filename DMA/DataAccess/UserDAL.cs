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
        private DMDBEntities Db;

        public UserDAL()
        {
            Db = new DMDBEntities();
        }

        public CustomBO AddUser(UserBO userBO)
        {
            CustomBO custom = new CustomBO();
            User user = new User() {
                UserID = userBO.UserID,
                UserName = userBO.UserName,
                UserAge = userBO.UserAge,
                UserWeight = userBO.UserWeight,
                UserCurrentGlucoseLevel = userBO.UserCurrentGlucoseLevel

            };
            Db.Users.Add(user);
            int returnValue = Db.SaveChanges();
            if (returnValue > 0)
            {
                custom.CustomMessage = "User details added Successfully";
                custom.CustomMessageNumber = returnValue;
            }
            else
            {
                custom.CustomMessage = "User details NOT Added !";
                custom.CustomMessageNumber = returnValue;
            }
            return custom;
        }
    }
}
