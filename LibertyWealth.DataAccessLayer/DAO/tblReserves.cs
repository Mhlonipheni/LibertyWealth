using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer.DAO
{
   public class tblReserves
    {
        public int ReservesId { get; set; }
        public int ReceiverId { get; set; }
        public int DonorId { get; set; }
        public double AmountReserved { get; set; }
        public DateTime DateReserved { get; set; }
        public Boolean DonorConfirmed { get; set; }
        public DateTime DateDonorConfirmed { get; set; }
        public Boolean ReceiverConfirmed { get; set; }
        public DateTime DateReceiverConfirmed { get; set; }
        public Boolean TransactionDone { get; set; }
    }
}
