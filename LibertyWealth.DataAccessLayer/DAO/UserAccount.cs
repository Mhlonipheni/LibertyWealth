using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer.DAO
{
   public class UserAccount
    {
        public int UserAccountId { get; set; }
        public int ClientId { get; set; }
        public int PayerId { get; set; }
        public double AmountPaid { get; set; }
        public int PercentageApplied { get; set; }
        public double Balance { get; set; }
        public Boolean ClientConfirmed { get; set; }
        public Boolean PayerConfirmed { get; set; }
        public DateTime DateCLientPaid { get; set; }
        public DateTime DatePayerAssigned { get; set; }
        public DateTime DatePayerConfirmed { get; set; }
    }
}
