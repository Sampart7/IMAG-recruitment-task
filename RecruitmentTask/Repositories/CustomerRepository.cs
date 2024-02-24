using Microsoft.EntityFrameworkCore;
using RecruitmentTask.Data;
using RecruitmentTaskShared.Entities;
using RecruitmentTask.Interfaces;

namespace RecruitmentTask.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _ctx;

        public CustomerRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _ctx.Customers.ToListAsync();
        }

        public async Task<Customer?> GetCustomerByIdAsync(int id)
        {
            return await _ctx.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void AddCustomerAsync(Customer newCustomer)
        {
            _ctx.Customers.Add(newCustomer);
        }

        public void UpdateCustomerAsync(Customer customer)
        {
            _ctx.Entry(customer).State = EntityState.Modified;
        }

        public void DeleteCustomerAsync(int id)
        {
            var customer = _ctx.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null) _ctx.Customers.Remove(customer);
        }
    }
}