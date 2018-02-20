using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccessLayer.DAO;
using LibertyWealth.DataAccessLayer.Interfaces;
namespace LibertyWealth.DataAccessLayer.DataStores
{
    public class tblCommentDataStore:ItblCommentDataStore
    {
        public readonly string Connection;
        public tblCommentDataStore(string connection)
        {
            Connection = connection;
        }

        public tblComment AddComment(tblComment contact)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(long contactId)
        {
            throw new NotImplementedException();
        }

        public IList<tblLookUpBank> GetAllcontact()
        {
            throw new NotImplementedException();
        }

        public tblComment GetCommentById(long contactId)
        {
            throw new NotImplementedException();
        }

        public tblComment UpdateComment(tblComment contact)
        {
            throw new NotImplementedException();
        }
    }
}
