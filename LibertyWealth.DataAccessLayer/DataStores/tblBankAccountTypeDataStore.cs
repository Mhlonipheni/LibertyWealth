using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.DataAccessLayer.DataStores
{
   public class tblBankAccountTypeDataStore : ItblBankAccountType
    {
        public readonly string Connection;
        public tblBankAccountTypeDataStore(string connection)
        {
            Connection = connection;
        }

        public tblBankAccountType AddAccountType(tblBankAccountType accountType)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccountType(long accountTypeId)
        {
            throw new NotImplementedException();
        }

        public tblBankAccountType GetAccountTypeById(long accountTypeId)
        {
            throw new NotImplementedException();
        }

        public IList<tblBankAccountType> GetAllAccountType()
        {
            throw new NotImplementedException();
        }

        public tblBankAccountType UpdateAccountType(tblBankAccountType accountType)
        {
            throw new NotImplementedException();
        }
    }
}
