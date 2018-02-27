using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccess.DAO
{
   public class tblComment
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
