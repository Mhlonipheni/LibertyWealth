using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.Entities
{
   public class tblBankDetails
    {
        public int BankDetails { get; set; }
        public int BankId { get; set; }
        public int UserId { get; set; }
        public string BranchCode { get; set; }
        public int BankAccountTypeId { get; set; }
        public int BankAccountNumber { get; set; }
    }
}
