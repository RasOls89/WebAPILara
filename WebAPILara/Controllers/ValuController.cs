using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPILara.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuController : ControllerBase
    {
        private readonly ModelStateDictionary Invalid;

        // GET: api/<ValuController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuController>/5
        [HttpGet("{id:int}")] ///The ? makes it optional. :int makes it so that the value have to be an int
        public IActionResult Get(int id, string query)
        {
            /*
             * if no return type void 
            return $"value {id}, query={ query}";
            */

            ///if IActionResult

            return Ok(new Valu { id = id, text = "value" + id });

        }

        // POST api/<ValuController>
        [HttpPost]
        public IActionResult Post([FromBody] Valu value)
        {
            if (ModelState != Invalid) ///Kollar modelstate, validerar data
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { id = value.id }, value);
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

        /// <summary>
        /// Lite klass för att skapa något att leka med
        /// </summary>
        public class Valu
        {
            public int id { get; set; }
            
            [MinLength(3)] ///Validation
            public string text { get; set; }
        }
    }
}
