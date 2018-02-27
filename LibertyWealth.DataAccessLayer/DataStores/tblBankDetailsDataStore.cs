using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
using LibertyWealth.DataAccess.Interfaces;
namespace LibertyWealth.DataAccess.DataStores
{
   public class tblBankDetailsDataStore:ItblBankDetailsDataStore
    {
        public readonly string Connection;
        public tblBankDetailsDataStore(string connection)
        {
            Connection = connection;
        }

        public tblBankDetails AddBankDetails(tblBankDetails bankDetails)
        {
            throw new NotImplementedException();
        }

        public void DeleteBankDetails(long bankDetailsId)
        {
            throw new NotImplementedException();
        }

        public IList<tblBankDetails> GetAllBankDetails()
        {
            throw new NotImplementedException();
        }

        public tblBankDetails GetBankDetailsById(long bankDetailsId)
        {
            throw new NotImplementedException();
        }

        public tblBankDetails UpdateBankDetails(tblBankDetails bankDetails)
        {
            throw new NotImplementedException();
        }
    }
}
