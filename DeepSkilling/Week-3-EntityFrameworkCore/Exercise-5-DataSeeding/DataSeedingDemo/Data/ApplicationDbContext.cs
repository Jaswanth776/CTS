using Microsoft.EntityFrameworkCore;
using DataSeedingDemo.Models;

namespace DataSeedingDemo.Data;

public class ApplicationDbContext : DbContext
{
    private readonly string _connectionString;

    public ApplicationDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Laptop",
                Category = "Electronics",
                Price = 70000,
                Stock = 15
            },
            new Product
            {
                ProductId = 2,
                Name = "Mouse",
                Category = "Electronics",
                Price = 800,
                Stock = 50
            },
            new Product
            {
                ProductId = 3,
                Name = "Chair",
                Category = "Furniture",
                Price = 5500,
                Stock = 10
            });
    }
}
