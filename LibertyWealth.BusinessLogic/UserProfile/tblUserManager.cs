using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.Entities;
using LibertyWealth.DataAccess.DAO;
using LibertyWealth.DataAccess.Interfaces;
namespace LibertyWealth.BusinessLogic.UserProfile
{
    public class tblUserManager
    {
        private static ItblUserDataStore _userStore;
        private static tblUserManager _instance;

        public static void RegisterManager(tblUserManager userManager, ItblUserDataStore userDataStore)
        {
            _instance = userManager;
            _userStore = userDataStore;

        }

        public static tblUserManager Instance => _instance;
        public Entities.tblUser AddUser(Entities.tblUser User)
        {
            var daoUSer = User.MapToDAO();
            var objUser = _userStore.AddUser(daoUSer);

            return objUser.MapToEntity();
        }

        public Entities.tblUser UpdateUser(Entities.tblUser User)
        {
            var daoUSer = User.MapToDAO();
            var objUser = _userStore.UpdateUser(daoUSer);

            return objUser.MapToEntity();
        }

        public Entities.tblUser GetUserById(long userId)
        {
            var User = _userStore.GetUserById(userId);

            return User?.MapToEntity();
        }

        
    }
    }
