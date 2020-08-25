using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NightSkyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            var currentUser = HttpContext.User;
            int spendingTimeWithCompany = 0;

            if (currentUser.HasClaim(c => c.Type == "DateOfCreation"))
            {
                DateTime date = DateTime.Parse(currentUser.Claims.FirstOrDefault(c => c.Type == "DateOfCreation").Value);
                spendingTimeWithCompany = DateTime.Today.Year - date.Year;
            }

            if (spendingTimeWithCompany > 5)
            {
                return new string[] { "valueHigh1", "valueHigh2" };
            }
            else
            {
                return new string[] { "value1", "value2",  };
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string[] Post([FromBody] string value)
        {
            return new string[] { "value1", "value2" };
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
