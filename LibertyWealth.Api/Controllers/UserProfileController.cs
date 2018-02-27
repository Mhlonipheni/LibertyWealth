using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibertyWealth.BusinessLogic.UserProfile;
using LibertyWealth.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibertyWealth.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/UserProfile")]
    public class UserProfileController : Controller
    {
        // GET: api/UserProfile
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserProfile/5
        [HttpGet("{id}", Name = "GetUserProfile")]
        public UserProfile GetUserProfile(int id)
        {
            return UserProfileManager.Instance.GetUserProfileById(id);
        }
        
        // POST: api/UserProfile
        [HttpPost]
        public UserProfile Post([FromBody]UserProfile value)
        {
            return UserProfileManager.Instance.AddUserProfile(value);
        }
        
        // PUT: api/UserProfile/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
