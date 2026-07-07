using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RetailInventorySystem.Data;
using RetailInventorySystem.Models;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false)
    .AddUserSecrets<Program>()
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection")!;
var password = configuration["Database:Password"]!;

connectionString = connectionString.Replace("{PASSWORD}", password);

using var context = new ApplicationDbContext(connectionString);

if (!context.Products.Any())
{
    context.Products.AddRange(
        new Product
        {
            Name = "Laptop",
            Price = 65000,
            Stock = 10
        },
        new Product
        {
            Name = "Mouse",
            Price = 750,
            Stock = 50
        });

    context.SaveChanges();

    Console.WriteLine("Products inserted successfully.\n");
}
else
{
    Console.WriteLine("Products already exist.\n");
}

Console.WriteLine("Available Products");
Console.WriteLine("------------------");

var products = context.Products
    .OrderBy(p => p.ProductId)
    .ToList();

foreach (var product in products)
{
    Console.WriteLine($"ID    : {product.ProductId}");
    Console.WriteLine($"Name  : {product.Name}");
    Console.WriteLine($"Price : {product.Price}");
    Console.WriteLine($"Stock : {product.Stock}");
    Console.WriteLine();
}
