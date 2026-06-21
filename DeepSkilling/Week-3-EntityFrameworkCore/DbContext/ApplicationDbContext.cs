using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreDemo.Models;

namespace EntityFrameworkCoreDemo.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
