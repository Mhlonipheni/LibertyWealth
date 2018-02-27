using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer.DataStores
{
    public class UserProfileDataStore : IUserProfileDataStore
    {
        public readonly string Connection;
        public UserProfileDataStore (string connection)
        {
            Connection = connection;
        }
        public UserProfile AddUserProfile(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserProfile(long userProfileId)
        {
            throw new NotImplementedException();
        }

        public UserProfile GetUserProfileById(long userProfileId)
        {
            throw new NotImplementedException();
        }

        public UserProfile GetUserProfileByUsernamePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public UserProfile UpdateUserProfile(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }
    }
}
