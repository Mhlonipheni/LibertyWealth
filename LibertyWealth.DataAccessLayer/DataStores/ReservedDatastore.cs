using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.DataAccessLayer.DataStores
{
   public class ReservedDatastore:IReservedDataStore
    {
        public readonly string connection;
    }
}
