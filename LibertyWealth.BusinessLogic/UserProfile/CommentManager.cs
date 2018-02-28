using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibertyWealth.DataAccess.Interfaces;

namespace LibertyWealth.BusinessLogic.UserProfile
{
    public class CommentManager
    {
        private static ItblCommentDataStore _commentStore;
        private static CommentManager _instance;

        public static void RegisterManager(CommentManager commentManager, ItblCommentDataStore commentDataStore)
        {
            _instance = commentManager;
            _commentStore = commentDataStore;

        }
        public static CommentManager Instance => _instance;
        public Entities.tblComment AddComment(Entities.tblComment userComment)
        {
            var daocomment = userComment.MapToDAO();
            var comment = _commentStore.AddComment(daocomment);
            return comment.MapToEntity();
        }
        public Entities.tblComment UpdateUser(Entities.tblComment userComment)
        {
            var daocomment = userComment.MapToDAO();
            var comment = _commentStore.UpdateComment(daocomment);

            return comment.MapToEntity();
        }
        public Entities.tblComment GetCommentById(long contactId)
        {
            var userComment = _commentStore.GetCommentById(contactId);

            return userComment?.MapToEntity();
        }
    }
}
