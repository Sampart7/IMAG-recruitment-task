using RecruitmentTaskShared.Entities;

namespace RecruitmentTask.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomersAsync(int skip, int take, bool sortByAsc, string column);
        Task<int> GetAmountOfCustomers();
        Task<Customer> GetCustomerByIdAsync(int id);
        void AddCustomerAsync(Customer newCustomer);
        void UpdateCustomerAsync(Customer customer);
        void DeleteCustomerAsync(int id);
    }
}