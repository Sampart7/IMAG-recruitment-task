using Microsoft.EntityFrameworkCore;
using RecruitmentTaskShared.Entities;

namespace RecruitmentTask.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Customer> Customers { get; set; }
    }
}