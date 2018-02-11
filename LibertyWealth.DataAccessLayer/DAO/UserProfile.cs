using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.DataAccessLayer.DAO
{
    public class UserProfile
    {
       public long UserProfileId { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string CountryCode { get; set; }
       public string MobilePhone { get; set; }
       public string HomePhone { get; set; }
       public string Email { get; set; }
       public string CurrencyCode { get; set; }
       public string Employer { get; set; }
       public DateTimeOffset CreatedDateTime { get; set; }
       public int SessionTimeoutMinutes { get; set; }
    }
}
