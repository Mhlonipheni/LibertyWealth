using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.DAO;
namespace LibertyWealth.DataAccess.Interfaces
{
    public interface ItblReservesDataStore
    {
        tblReserves AddReserve(tblReserves reserves);
        tblReserves UpdateRerve(tblReserves reserves);
        tblReserves GetReservesById(long reserveId);
        IList<tblReserves> GetAllReserves();
        void DeleteReserves(long reserveId);
    }
}
