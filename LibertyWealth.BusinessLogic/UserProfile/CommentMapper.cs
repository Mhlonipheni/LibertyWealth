using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWealth.BusinessLogic.UserProfile
{
   public static class CommentMapper
    {
        public static Entities.tblComment MapToEntity(this DataAccess.DAO.tblComment dao)
        {
            var mapToEntity = new Entities.tblComment
            {
                ContactId = dao.ContactId,
                Name = dao.Name,
                Surname = dao.Surname,
                Comment = dao.Comment,
                Email = dao.Email,
                Cellphone = dao.Cellphone,
                DateCreated = dao.DateCreated

            };

            return mapToEntity;
        }

        public static DataAccess.DAO.tblComment MapToDAO(this Entities.tblComment comment)
        {
            var userComment = new DataAccess.DAO.tblComment
            {
                ContactId = comment.ContactId,
                Name = comment.Name,
                Surname = comment.Surname,
                Comment = comment.Comment,
                Email = comment.Email,
                Cellphone = comment.Cellphone,
                DateCreated = comment.DateCreated
            };

            return userComment;
        }
    }
}
