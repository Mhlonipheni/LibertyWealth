using LibertyWealth.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.Entities;
namespace LibertyWealth.BusinessLogic.UserProfile
{
    public class UserProfileManager
    {
        private static UserProfileManager _instance;
        private static IUserProfileDataStore _dataStore;
        public static void RegisterManager(UserProfileManager userProfileManager, IUserProfileDataStore userProfileDataStore)
        {
            _instance = userProfileManager;
            _dataStore = userProfileDataStore;
        }
        public static UserProfileManager Instance => _instance;
        public Entities.UserProfile AddUserProfile(Entities.UserProfile userProfile)
        {
            var daoUserProfile = userProfile.MapToDao();
            var profile = _dataStore.AddUserProfile(daoUserProfile);
            return profile.MapToEntity();
        }
        public Entities.UserProfile GetUserProfileById(long userProfileId)
        {
            var userProfile = _dataStore.GetUserProfileById(userProfileId);
            return userProfile?.MapToEntity();
        }
        public Entities.UserProfile GetUserProfileByUsernamePassword(string username, string password)
        {
            var userProfile = _dataStore.GetUserProfileByUsernamePassword(username,password);
            return userProfile?.MapToEntity();
        }
    }
}
