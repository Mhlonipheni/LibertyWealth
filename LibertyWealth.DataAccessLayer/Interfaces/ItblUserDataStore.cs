using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.Entities;

namespace LibertyWealth.DataAccessLayer.Interfaces
{
    public interface ItblUserDataStore
    {
        bool AddUser(tblUser user);
        bool UpdateUser(tblUser user);
        bool GetUserById(long userId);
        IList<tblUser> GetAllUser();
        bool DeleteUser(long userId);
   
    }
}
