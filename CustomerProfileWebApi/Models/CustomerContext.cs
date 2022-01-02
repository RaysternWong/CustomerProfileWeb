using Microsoft.EntityFrameworkCore;

namespace CustomerProfileWeb.Models
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set;}

        public CustomerContext(DbContextOptions<CustomerContext> option) : base(option)
        {

        }
    }
}
