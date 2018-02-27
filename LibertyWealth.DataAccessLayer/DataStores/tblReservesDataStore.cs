using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
using LibertyWealth.DataAccess.Interfaces;
namespace LibertyWealth.DataAccess.DataStores
{
   public class tblReservesDataStore:ItblReservesDataStore
    {
        public readonly string Connection;
        public tblReservesDataStore(string connection)
        {
            Connection = connection;
        }

        public tblReserves AddReserve(tblReserves reserves)
        {
            throw new NotImplementedException();
        }

        public void DeleteReserves(long reserveId)
        {
            throw new NotImplementedException();
        }

        public IList<tblReserves> GetAllReserves()
        {
            throw new NotImplementedException();
        }

        public tblReserves GetReservesById(long reserveId)
        {
            throw new NotImplementedException();
        }

        public tblReserves UpdateRerve(tblReserves reserves)
        {
            throw new NotImplementedException();
        }
    }
}
