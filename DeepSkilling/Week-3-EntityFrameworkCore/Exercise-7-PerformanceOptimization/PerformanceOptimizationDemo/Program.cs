using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PerformanceOptimizationDemo.Data;
using PerformanceOptimizationDemo.Models;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .AddUserSecrets<Program>()
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection")!;
var password = configuration["Database:Password"]!;

connectionString = connectionString.Replace("{PASSWORD}", password);

using var context = new ApplicationDbContext(connectionString);

if (!context.Products.Any())
{
    context.Products.AddRange(
        new Product { Name = "Laptop", Category = "Electronics", Price = 70000, Stock = 15 },
        new Product { Name = "Mouse", Category = "Electronics", Price = 800, Stock = 50 },
        new Product { Name = "Keyboard", Category = "Electronics", Price = 1500, Stock = 30 },
        new Product { Name = "Chair", Category = "Furniture", Price = 5500, Stock = 10 },
        new Product { Name = "Desk", Category = "Furniture", Price = 12000, Stock = 5 }
    );

    context.SaveChanges();
}

Console.WriteLine("===== Normal Query =====");

var normalProducts = context.Products.ToList();

foreach (var product in normalProducts)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}

Console.WriteLine();

Console.WriteLine("===== AsNoTracking =====");

var noTrackingProducts = context.Products
    .AsNoTracking()
    .ToList();

foreach (var product in noTrackingProducts)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}

Console.WriteLine();

Console.WriteLine("===== Projection =====");

var projected = context.Products
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToList();

foreach (var item in projected)
{
    Console.WriteLine($"{item.Name} - {item.Price}");
}

Console.WriteLine();

Console.WriteLine("===== Pagination =====");

var page = context.Products
    .OrderBy(p => p.ProductId)
    .Skip(2)
    .Take(2)
    .ToList();

foreach (var product in page)
{
    Console.WriteLine(product.Name);
}

Console.WriteLine();

Console.WriteLine("===== Indexed Query =====");

var electronics = context.Products
    .Where(p => p.Category == "Electronics")
    .ToList();

foreach (var product in electronics)
{
    Console.WriteLine(product.Name);
}
