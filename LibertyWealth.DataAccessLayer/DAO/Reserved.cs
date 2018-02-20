using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer.DAO
{
   public class Reserved
    {
        public int ReservedId { get; set; }
        public int ReceiverUserId { get; set; }
        public int DonorUserId { get; set; }
        public string AmountDonorPromisedToGive { get; set; }
        public Boolean DonorApproved { get; set; }
        public Boolean RecieverApprove { get; set; }
    }
}
