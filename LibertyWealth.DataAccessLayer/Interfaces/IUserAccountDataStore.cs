using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
namespace LibertyWealth.DataAccessLayer.Interfaces
{
    public interface IUserAccountDataStore
    {
        UserAccount AddUserAccount(UserAccount userAccount);
        UserAccount UpdateUserAccount(UserAccount userAccount);
        UserAccount GetUserAccountById(long userAccountId);
        IList<UserAccount> GetAllUserAccount();
        void DeleteUserAccount(long userAccountId);
    }
}
