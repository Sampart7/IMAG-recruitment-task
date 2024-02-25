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

        public async Task<List<Customer>> GetCustomersAsync(int skip, int take, bool sortByAsc, string column)
        {
            var query = _ctx.Customers.AsQueryable();

            query = column switch
            {
                "Id" => sortByAsc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
                "Name" => sortByAsc ? query.OrderBy(x => x.Name) : query.OrderByDescending(x => x.Name),
                "Address" => sortByAsc ? query.OrderBy(x => x.Address) : query.OrderByDescending(x => x.Address),
                "NIP" => sortByAsc ? query.OrderBy(x => x.NIP) : query.OrderByDescending(x => x.NIP),
                _ => query.OrderBy(x => x.Id)
            };

            return await query.Skip(skip).Take(take).ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
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

        public Task<int> GetAmountOfCustomers()
        {
            return _ctx.Customers.CountAsync();
        }
    }
}