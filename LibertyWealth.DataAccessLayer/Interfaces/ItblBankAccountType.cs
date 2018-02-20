using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
namespace LibertyWealth.DataAccessLayer.Interfaces
{
    public interface ItblBankAccountType
    {
        tblBankAccountType AddAccountType(tblBankAccountType accountType);
        tblBankAccountType UpdateAccountType(tblBankAccountType accountType);
        tblBankAccountType GetAccountTypeById(long accountTypeId);
        IList<tblBankAccountType> GetAllAccountType();
        void DeleteAccountType(long accountTypeId);
    }
}
