namespace RecruitmentTask.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        Task<bool> CompleteAsync();
        bool HasChanges();
    }
}