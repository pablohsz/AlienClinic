using AC.Core.Domain;
using AC.Core.Shared.ModelViews;
using AC.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace AC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerManager clientManager;

        

        public CustomerController(ICustomerManager clientManager)
        {
            this.clientManager = clientManager;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await clientManager.GetCustomersAsync());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await clientManager.GetCustumerAsync(id)); ;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Post(NewCustomer newCustomer)
        {
            var inputedCustumer = await clientManager.InsertCustumerAsync(newCustomer);
            return CreatedAtAction(nameof(Get), new { id = inputedCustumer.Id }, inputedCustumer);

        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        public async Task<IActionResult> Put(AlterCustomer alterCustomer)
        {
            var updatedCustomer = await clientManager.UpdateCustumerAsync(alterCustomer);
            if(updatedCustomer == null)
            {
                return NotFound();
            }
            return Ok(updatedCustomer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await clientManager.DeleteCustumerAsync(id);
            return NoContent();
        }
    }
}
