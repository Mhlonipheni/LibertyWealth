using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.DataAccessLayer.DataStores
{
   public class tblUserDataStore:ItblUserDataStore
    {
        public readonly string Connection;
        public tblUserDataStore(string connection)
        {
            Connection = connection;
        }

        public tblUser AddUser(tblUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(long userId)
        {
            throw new NotImplementedException();
        }

        public IList<tblUser> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public tblUser GetUserById(long userId)
        {
            throw new NotImplementedException();
        }

        public tblUser UpdateUser(tblUser user)
        {
            throw new NotImplementedException();
        }
    }
}
