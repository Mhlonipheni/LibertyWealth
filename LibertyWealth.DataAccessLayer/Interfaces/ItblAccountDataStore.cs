using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;

namespace LibertyWealth.DataAccessLayer.Interfaces
{
    public interface ItblAccountDataStore
    {
        tblAccount AddAccount(tblAccount account);
        tblAccount UpdateAccount(tblAccount account);
        tblAccount GetAccountById(long accoundId);
        IList<tblAccount> GetAllaccount();
        void DeleteAccount(long accountId);
    }
}
