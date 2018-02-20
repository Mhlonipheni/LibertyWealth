using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer.DAO
{
  public  class tblRegistration
    {
        public int RegisterId { get; set; }
        public int UserId { get; set; }
        public string OTPGenerated { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
