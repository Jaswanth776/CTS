using Microsoft.EntityFrameworkCore;
using LoadingStrategiesDemo.Models;

namespace LoadingStrategiesDemo.Data;

public class ApplicationDbContext : DbContext
{
    private readonly string _connectionString;

    public ApplicationDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee> Employees => Set<Employee>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .HasMany(d => d.Employees)
            .WithOne(e => e.Department)
            .HasForeignKey(e => e.DepartmentId);
    }
}
