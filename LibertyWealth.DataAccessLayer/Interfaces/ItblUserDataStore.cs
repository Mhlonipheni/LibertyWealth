using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
namespace LibertyWealth.DataAccessLayer.Interfaces
{
    public interface ItblUserDataStore
    {
        tblUser AddUser(tblUser user);
        tblUser UpdateUser(tblUser user);
        tblUser GetUserById(long userId);
        IList<tblUser> GetAllUser();
        void DeleteUser(long userId);
    }
}
