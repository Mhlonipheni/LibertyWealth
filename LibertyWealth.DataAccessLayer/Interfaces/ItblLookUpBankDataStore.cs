using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
namespace LibertyWealth.DataAccess.Interfaces
{
    public interface ItblLookUpBankDataStore
    {
        tblLookUpBank AddBank(tblLookUpBank bank);
        tblLookUpBank UpdateBank(tblLookUpBank bank);
        tblLookUpBank GetBankById(long bankId);
        IList<tblLookUpBank> GetAllbank();
        void DeleteBank(long bankId);
    }
}
