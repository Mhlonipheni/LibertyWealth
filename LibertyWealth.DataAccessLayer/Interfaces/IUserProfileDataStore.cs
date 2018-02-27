using LibertyWealth.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccess.Interfaces
{
    public interface IUserProfileDataStore
    {
        UserProfile AddUserProfile(UserProfile userProfile);
        UserProfile UpdateUserProfile(UserProfile userProfile);
        UserProfile GetUserProfileById(long userProfileId);
        UserProfile GetUserProfileByUsernamePassword(string username, string password);
        void DeleteUserProfile(long userProfileId);
    }
}
