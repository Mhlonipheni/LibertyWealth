using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibertyWealth.Entities;
using LibertyWealth.BusinessLogic.UserProfile;

namespace LibertyWealth.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/tblUser")]
    public class tblUserController : Controller
    {
        // GET: api/tblUser
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/tblUser/5
        [HttpGet("{id}", Name = "GetUserProfile")]
        public tblUser GetUserProfile(int id)
        {
            return tblUserManager.Instance.GetUserById(id);
        }
        
        // POST: api/tblUser
        [HttpPost]
        public tblUser Post([FromBody]tblUser user)
        {
            return tblUserManager.Instance.AddUser(user);
        }
        
        // PUT: api/tblUser/5
        [HttpPut("{id}")]
        public tblUser Put(int id, [FromBody]tblUser user)
        {
            return tblUserManager.Instance.UpdateUser(user);
        }
        
        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    _userStore.DeleteUser(id);
        //}
    }
}
