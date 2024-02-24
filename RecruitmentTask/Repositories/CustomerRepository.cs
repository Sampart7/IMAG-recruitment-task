using Microsoft.EntityFrameworkCore;
using RecruitmentTask.Data;
using RecruitmentTaskShared.Entities;
using RecruitmentTask.Interfaces;
using RecruitmentTaskShared.Paging;

namespace RecruitmentTask.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _ctx;

        public CustomerRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<PagedList<Customer>> GetCustomersAsync(PaginationParams paginationParams)
        {
            var query = _ctx.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(paginationParams.SortBy))
            {
                switch (paginationParams.SortBy.ToLower())
                {
                    case "id":
                        query = paginationParams.SortDescending
                            ? query.OrderByDescending(c => c.Id)
                            : query.OrderBy(c => c.Id);
                        break;
                    case "name":
                        query = paginationParams.SortDescending
                            ? query.OrderByDescending(c => c.Name)
                            : query.OrderBy(c => c.Name);
                        break;
                    case "address":
                        query = paginationParams.SortDescending
                            ? query.OrderByDescending(c => c.Address)
                            : query.OrderBy(c => c.Address);
                        break;
                    case "nip":
                        query = paginationParams.SortDescending
                            ? query.OrderByDescending(c => c.NIP)
                            : query.OrderBy(c => c.NIP);
                        break;
                }
            }

            return await PagedList<Customer>
                .CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
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