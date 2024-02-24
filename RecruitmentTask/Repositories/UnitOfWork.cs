using RecruitmentTask.Interfaces;
using RecruitmentTask.Data;

namespace RecruitmentTask.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _ctx;

        public UnitOfWork(DataContext ctx)
        {
            _ctx = ctx;
        }

        public ICustomerRepository CustomerRepository => new CustomerRepository(_ctx);

        public async Task<bool> CompleteAsync()
        {
            return await _ctx.SaveChangesAsync() > 0;
        }

        public bool HasChanges()
        {
            return _ctx.ChangeTracker.HasChanges();
        }
    }
}