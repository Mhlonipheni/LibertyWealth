using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.Entities;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.BusinessLogic.UserProfile
{
   public class tblUserManager
    {
        ItblUserDataStore _userStore;

        public tblUserManager(ItblUserDataStore userStore)
        {
            _userStore = userStore;
        }

        public bool AddUser(tblUser user)
        {
            return _userStore.AddUser(user);
        }

        public bool UpdateUser(tblUser user)
        {
            return _userStore.UpdateUser(user);
        }

        public bool DeleteUser(int userid)
        {
            return _userStore.DeleteUser(userid);
        }

        public IList<tblUser> GetAllUser()
        {
            return _userStore.GetAllUser();
        }
    }
}
