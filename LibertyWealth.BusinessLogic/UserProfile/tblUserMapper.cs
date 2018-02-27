using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.BusinessLogic.UserProfile
{
   public static class tblUserMapper
    {
        public static Entities.tblUser User(this Entities.tblUser Userinput)
        {
            return new Entities.tblUser()
            {
                UserId = Userinput.UserId,
                FirstName = Userinput.FirstName,
                Surname = Userinput.Surname,
                CellphoneNumber = Userinput.CellphoneNumber,
                UserRoleId = Userinput.UserRoleId,
                DateCreated = Userinput.DateCreated,
                Email = Userinput.Email,
                EmailConfirmed = Userinput.EmailConfirmed,
                TwoFactorCount = Userinput.TwoFactorCount,
                LockedOut = Userinput.LockedOut,
                Password = Userinput.Password,
            };
        } 

       public static DataAccess.DAO.tblUser MapToDAO(this Entities.tblUser objUSer)
        {
            var Userinput = new DataAccess.DAO.tblUser
            {
                UserId = objUSer.UserId,
                FirstName = objUSer.FirstName,
                Surname = objUSer.Surname,
                CellphoneNumber = objUSer.CellphoneNumber,
                UserRoleId = objUSer.UserRoleId,
                DateCreated = objUSer.DateCreated,
                Email = objUSer.Email,
                EmailConfirmed = objUSer.EmailConfirmed,
                TwoFactorCount = objUSer.TwoFactorCount,
                LockedOut = objUSer.LockedOut,
                Password = objUSer.Password,
            };
            return Userinput;
        }
    }
}
