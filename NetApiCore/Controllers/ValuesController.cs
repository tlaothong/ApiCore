using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetApiCore.Controllers
{
    /// <summary>
    /// We dont' need this
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// Just get array
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Get with id
        /// </summary>
        /// <param name="id">An id parameter</param>
        /// <returns>some string</returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Post simple
        /// </summary>
        /// <param name="value">string value</param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Just put something
        /// </summary>
        /// <param name="id">input id</param>
        /// <param name="value">some value</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// A delete method
        /// </summary>
        /// <param name="id">Rest id to be deleted</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
