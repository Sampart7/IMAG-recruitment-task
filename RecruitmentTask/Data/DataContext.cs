using Microsoft.EntityFrameworkCore;
using RecruitmentTaskShared.Entities;

namespace RecruitmentTask.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var customers = new List<Customer>();

            for (int i = 1; i <= 50; i++)
            {
                customers.Add(new Customer
                {
                    Id = i,
                    Name = GenerateRandomString(3, 16),
                    Address = GenerateRandomString(3, 24),
                    NIP = GenerateRandomNIP()
                });
            }

            modelBuilder.Entity<Customer>().HasData(customers.ToArray());
        }

        private string GenerateRandomString(int minLength, int maxLength)
        {
            var random = new Random();
            var length = random.Next(minLength, maxLength + 1);

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private int GenerateRandomNIP()
        {
            var random = new Random();
            return random.Next(1000000000, 2147483647);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}