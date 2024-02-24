using Microsoft.AspNetCore.Mvc;
using RecruitmentTask.Interfaces;
using RecruitmentTaskShared.Entities;

namespace RecruitmentTask.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomersAsync()
        {
            var customers = await _unitOfWork.CustomerRepository.GetCustomersAsync();
            if (customers == null) return NotFound("Customers not found");

            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerAsync(int id)
        {
            var customer = await _unitOfWork.CustomerRepository.GetCustomerByIdAsync(id);
            if (customer == null) return NotFound("Customer not found");

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomersAsync(Customer newCustomer)
        {
            _unitOfWork.CustomerRepository.AddCustomerAsync(newCustomer);
            if (await _unitOfWork.CompleteAsync()) return Ok();

            return BadRequest("Failed to add customer");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomersAsync(int id)
        {
            _unitOfWork.CustomerRepository.DeleteCustomerAsync(id);
            if (await _unitOfWork.CompleteAsync()) return Ok();

            return BadRequest("Failed to delete customer");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> UpdateCustomersAsync(int id, Customer customer)
        {
            var existingCustomer = await _unitOfWork.CustomerRepository.GetCustomerByIdAsync(id);
            if (existingCustomer == null) return NotFound("Customer not found");

            existingCustomer.Name = customer.Name;
            existingCustomer.Address = customer.Address;
            existingCustomer.NIP = customer.NIP;

            _unitOfWork.CustomerRepository.UpdateCustomerAsync(existingCustomer);

            if (await _unitOfWork.CompleteAsync()) return Ok(existingCustomer);

            return BadRequest("Failed to update customer");
        }
    }
}
