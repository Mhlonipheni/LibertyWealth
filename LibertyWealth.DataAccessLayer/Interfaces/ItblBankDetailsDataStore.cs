using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
namespace LibertyWealth.DataAccess.Interfaces
{
    public interface ItblBankDetailsDataStore
    {
        tblBankDetails AddBankDetails(tblBankDetails bankDetails);
        tblBankDetails UpdateBankDetails(tblBankDetails bankDetails);
        tblBankDetails GetBankDetailsById(long bankDetailsId);
        IList<tblBankDetails> GetAllBankDetails();
        void DeleteBankDetails(long bankDetailsId);
    }
}
