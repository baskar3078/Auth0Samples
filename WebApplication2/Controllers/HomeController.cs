using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        // GET api/home
        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/home/5
        [HttpGet("{id}")]
        [Authorize("read:records")]
        public string Get(int id)
        {
            return "Hitting Get Id Method with Proper Values";
        }

        // POST api/home
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/home/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
