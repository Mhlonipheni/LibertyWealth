using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer.DAO
{
   public class tblAccount
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public double MoneyPaid { get; set; }
        public string PercentageApplied { get; set; }
        public DateTime DateMoneyPaid { get; set; }
        public double AmountExpected { get; set; }
        public double AmountOnReserves { get; set; }
        public double AmountRemaining { get; set; }
        public Boolean OnThelist { get; set; }
    }
}
