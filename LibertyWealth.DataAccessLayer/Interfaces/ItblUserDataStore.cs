using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;

namespace LibertyWealth.DataAccess.Interfaces
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
