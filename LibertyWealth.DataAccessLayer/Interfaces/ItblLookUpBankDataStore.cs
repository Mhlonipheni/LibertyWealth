using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
namespace LibertyWealth.DataAccessLayer.Interfaces
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
