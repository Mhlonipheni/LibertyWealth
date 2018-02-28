using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.BusinessLogic.UserProfile
{
   public static class tblUserMapper
    {
        public static Entities.tblUser MapToEntity(this DataAccess.DAO.tblUser daouser)
        {
            var mapToEntity = new Entities.tblUser
            {
                UserId = daouser.UserId,
                FirstName = daouser.FirstName,
                Surname = daouser.Surname,
                CellphoneNumber = daouser.CellphoneNumber,
                UserRoleId = daouser.UserRoleId,
                DateCreated = daouser.DateCreated,
                Email = daouser.Email,
                EmailConfirmed = daouser.EmailConfirmed,
                TwoFactorCount = daouser.TwoFactorCount,
                LockedOut = daouser.LockedOut,
                Password = daouser.Password,
            };
            return mapToEntity;
        } 

       public static DataAccess.DAO.tblUser MapToDAO(this Entities.tblUser objUser)
        {
            var User = new DataAccess.DAO.tblUser
            {
                UserId = objUser.UserId,
                FirstName = objUser.FirstName,
                Surname = objUser.Surname,
                CellphoneNumber = objUser.CellphoneNumber,
                UserRoleId = objUser.UserRoleId,
                DateCreated = objUser.DateCreated,
                Email = objUser.Email,
                EmailConfirmed = objUser.EmailConfirmed,
                TwoFactorCount = objUser.TwoFactorCount,
                LockedOut = objUser.LockedOut,
                Password = objUser.Password,
            };
            return User;
        }
    }
}
