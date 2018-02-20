using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.DataAccessLayer.DataStores
{
   public class tblRegistrationDataStore:ItblRegistrationDataStore
    {
        public readonly String Connection;
        public tblRegistrationDataStore(string connection)
        {
            Connection = connection;
        }

        public tblRegistration AddRegistration(tblRegistration registration)
        {
            throw new NotImplementedException();
        }

        public void DeleteRegitsration(long regId)
        {
            throw new NotImplementedException();
        }

        public IList<tblRegistration> GetAllRegistration()
        {
            throw new NotImplementedException();
        }

        public tblRegistration GetReById(long regId)
        {
            throw new NotImplementedException();
        }

        public tblRegistration UpdateRegistraion(tblRegistration registration)
        {
            throw new NotImplementedException();
        }
    }
}
