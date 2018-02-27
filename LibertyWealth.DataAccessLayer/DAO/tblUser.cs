using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccess.DAO
{
   public class tblUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CellphoneNumber { get; set; }
        public int UserRoleId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public Boolean EmailConfirmed { get; set; }
        public int TwoFactorCount { get; set; }
        public Boolean LockedOut { get; set; }
        public string Password { get; set; }
    }
}
