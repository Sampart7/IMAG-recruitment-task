using RecruitmentTaskShared.Entities;
using RecruitmentTaskShared.Paging;

namespace RecruitmentTask.Interfaces
{
    public interface ICustomerRepository
    {
        Task<PagedList<Customer>> GetCustomersAsync(PaginationParams paginationParams);
        Task<Customer> GetCustomerByIdAsync(int id);
        void AddCustomerAsync(Customer newCustomer);
        void UpdateCustomerAsync(Customer customer);
        void DeleteCustomerAsync(int id);
    }
}