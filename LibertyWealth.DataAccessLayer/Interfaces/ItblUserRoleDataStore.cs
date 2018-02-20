using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
namespace LibertyWealth.DataAccessLayer.Interfaces
{
    public interface ItblUserRoleDataStore
    {
        tblUserRole AddUserRole(tblUserRole userRole);
        tblUserRole UpdateUserRole(tblUserRole userRole);
        tblUserRole GetUserRoleById(long userRoleId);
        IList<tblUserRole> GetAllUserRole();
        void DeleteUserRole(long userRoleId);
    }
}
