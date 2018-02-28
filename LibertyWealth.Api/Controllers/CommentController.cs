using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibertyWealth.BusinessLogic.UserProfile;
using LibertyWealth.Entities;


namespace LibertyWealth.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Comment")]
    public class CommentController : Controller
    {
        // GET: api/Comment
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Comment/5
        [HttpGet("{id}", Name = "GetComments")]
        public tblComment GetComments(int id)
        {
            return CommentManager.Instance.GetCommentById(id);
        }
        
        // POST: api/Comment
        [HttpPost]
        public tblComment Post([FromBody]tblComment value)
        {
            return CommentManager.Instance.AddComment(value);
        }
        
        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public tblComment Put(int id, [FromBody]tblComment value)
        {
            return CommentManager.Instance.UpdateUser(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
