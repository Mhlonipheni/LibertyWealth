using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
using LibertyWealth.DataAccess.Interfaces;
namespace LibertyWealth.DataAccess.DataStores
{
   public class tblAccountDataStore:ItblAccountDataStore
    {
        public readonly string Connection;
        public tblAccountDataStore(string connection)
        {
            Connection = connection;
        }

        public tblAccount AddAccount(tblAccount account)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(long accountId)
        {
            throw new NotImplementedException();
        }

        public tblAccount GetAccountById(long accoundId)
        {
            throw new NotImplementedException();
        }

        public IList<tblAccount> GetAllaccount()
        {
            throw new NotImplementedException();
        }

        public tblAccount UpdateAccount(tblAccount account)
        {
            throw new NotImplementedException();
        }
    }
}
