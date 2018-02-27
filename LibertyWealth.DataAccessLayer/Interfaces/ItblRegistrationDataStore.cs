using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
namespace LibertyWealth.DataAccess.Interfaces
{
    public interface ItblRegistrationDataStore
    {
        tblRegistration AddRegistration(tblRegistration registration);
        tblRegistration UpdateRegistraion(tblRegistration registration);
        tblRegistration GetReById(long regId);
        IList<tblRegistration> GetAllRegistration();
        void DeleteRegitsration(long regId);
    }
}
