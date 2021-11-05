using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPILara.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuController : ControllerBase
    {
        // GET: api/<ValuController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuController>/5
        [HttpGet("{id:int}")] ///The ? makes it optional. :int makes it so that the value have to be an int
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/<ValuController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
