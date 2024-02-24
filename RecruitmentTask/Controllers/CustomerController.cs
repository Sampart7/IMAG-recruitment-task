using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecruitmentTask.Data;
using RecruitmentTaskShared.Entities;

namespace RecruitmentTask.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _ctx;

        public CustomerController(DataContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomersAsync() 
        {
            return await _ctx.Customers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerAsync(int id) 
        {
            var result = await _ctx.Customers.FindAsync(id);
            if (result == null) return NotFound("Customer not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomersAsync(Customer newCustomer) 
        {
            _ctx.Add(newCustomer);
            await _ctx.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomersAsync(int id) 
        {
            var result = await _ctx.Customers.FindAsync(id);
            if (result == null) return NotFound("Customer not found");

            _ctx.Remove(result);
            await _ctx.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> UpdateCustomersAsync(int id, Customer customer) 
        {
            var result = await _ctx.Customers.FindAsync(id);
            if (result == null) return NotFound("Customer not found");

            result.Name = customer.Name;
            result.Address = customer.Address;
            result.NIP = customer.NIP;

            await _ctx.SaveChangesAsync();

            return Ok();
        }
    }
}
