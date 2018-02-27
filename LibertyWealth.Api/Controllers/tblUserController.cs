using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibertyWealth.Entities;
using LibertyWealth.DataAccess.Interfaces;

namespace LibertyWealth.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/tblUser")]
    public class tblUserController : Controller
    {
        ItblUserDataStore _userStore;
        public tblUserController(ItblUserDataStore userStore)
        {
            _userStore = userStore;
        }

        // GET: api/tblUser
        [HttpGet]
        public IEnumerable<tblUser> Get()
        {
            return _userStore.GetAllUser();
        }

        // GET: api/tblUser/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/tblUser
        [HttpPost]
        public void Post([FromBody]tblUser user)
        {
          _userStore.AddUser(user);
        }
        
        // PUT: api/tblUser/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]tblUser user)
        {
            _userStore.UpdateUser(user);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userStore.DeleteUser(id);
        }
    }
}
