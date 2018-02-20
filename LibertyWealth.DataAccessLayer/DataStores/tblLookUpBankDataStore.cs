using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.DataAccessLayer.DataStores
{
   public class tblLookUpBankDataStore:ItblLookUpBankDataStore
    {
        public readonly string Connection;
        public tblLookUpBankDataStore(string connection)
        {
            Connection = connection;
        }

        public tblLookUpBank AddBank(tblLookUpBank bank)
        {
            throw new NotImplementedException();
        }

        public void DeleteBank(long bankId)
        {
            throw new NotImplementedException();
        }

        public IList<tblLookUpBank> GetAllbank()
        {
            throw new NotImplementedException();
        }

        public tblLookUpBank GetBankById(long bankId)
        {
            throw new NotImplementedException();
        }

        public tblLookUpBank UpdateBank(tblLookUpBank bank)
        {
            throw new NotImplementedException();
        }
    }
}
