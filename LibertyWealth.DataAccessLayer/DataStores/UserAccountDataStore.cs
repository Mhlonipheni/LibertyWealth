using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.DataAccessLayer.DataStores
{
   public class UserAccountDataStore:IUserAccountDataStore
    {
        public readonly string Connection;
        public UserAccountDataStore(string connection)
        {
            Connection = connection;
        }

        public UserAccount AddUserAccount(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserAccount(long userAccountId)
        {
            throw new NotImplementedException();
        }

        public IList<UserAccount> GetAllUserAccount()
        {
            throw new NotImplementedException();
        }

        public UserAccount GetUserAccountById(long userAccountId)
        {
            throw new NotImplementedException();
        }

        public UserAccount UpdateUserAccount(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
