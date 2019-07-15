using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularIteaBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", "value3", "value4", "value5", "value6" };
        }

        [HttpGet("NumberList")]
        public ActionResult<IEnumerable<int>> GetNumList()
        {
            return new int[] { 1, 2, 3, 4, 55, 77, 99, 99, 33, 55, 34, 9, 2, 1, 65, 23 };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetParametrs(int id)
        {
            return "Get Parametrs -" + id;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] DataValue value)
        {
            string rzlt = "Post Reqest sucsess: " + value.Value;
            return rzlt;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] DataValue value)
        {
            string rzlt = "Put Reqest sucsess - " + value.Value + " - With parametr:" + id;
            return rzlt;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


    public class DataValue {
        public int MyInt { get; set; }
        public string Value { get; set; }
    }

}
