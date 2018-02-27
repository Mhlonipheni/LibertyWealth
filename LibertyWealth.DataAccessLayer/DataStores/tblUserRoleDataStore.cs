using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
using LibertyWealth.DataAccess.Interfaces;
namespace LibertyWealth.DataAccess.DataStores
{
   public class tblUserRoleDataStore:ItblUserRoleDataStore
    {
        public readonly string Connection;
        public tblUserRoleDataStore(string connection)
        {
            Connection = connection;

        }

        public tblUserRole AddUserRole(tblUserRole userRole)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserRole(long userRoleId)
        {
            throw new NotImplementedException();
        }

        public IList<tblUserRole> GetAllUserRole()
        {
            throw new NotImplementedException();
        }

        public tblUserRole GetUserRoleById(long userRoleId)
        {
            throw new NotImplementedException();
        }

        public tblUserRole UpdateUserRole(tblUserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}
