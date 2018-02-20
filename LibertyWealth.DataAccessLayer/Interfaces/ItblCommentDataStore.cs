using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
namespace LibertyWealth.DataAccessLayer.Interfaces
{
    public interface ItblCommentDataStore
    {
        tblComment AddComment(tblComment contact);
        tblComment UpdateComment(tblComment contact);
        tblComment GetCommentById(long contactId);
        IList<tblLookUpBank> GetAllcontact();
        void DeleteComment(long contactId);
    }
}
