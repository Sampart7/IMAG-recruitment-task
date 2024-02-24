using RecruitmentTaskShared.Entities;

namespace RecruitmentTask.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        void AddCustomerAsync(Customer newCustomer);
        void UpdateCustomerAsync(Customer customer);
        void DeleteCustomerAsync(int id);
    }
}