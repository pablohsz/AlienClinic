using AC.Core.Domain;
using Microsoft.AspNetCore.Mvc;


namespace AC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Customer>()
            {
                new Customer
                {
                    Id = 1,
                    Name = "Francis Abadia",
                    Birthdate = new DateTime(1980, 01, 01)
                },
                new Customer
                {
                    Id = 2,
                    Name = "Francis Abadia",
                    Birthdate = new DateTime(1980, 01, 01)
                }
            });
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
