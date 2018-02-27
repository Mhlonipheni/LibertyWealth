using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
using LibertyWealth.DataAccess.Interfaces;
namespace LibertyWealth.DataAccess.DataStores
{
   public class tblListDataStore:ItblListDataStore
    {
        public readonly string Connection;
        public tblListDataStore(string connection)
        {
            Connection = connection;
        }
    }
}
