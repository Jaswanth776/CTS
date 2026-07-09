using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LINQQueriesDemo.Data;
using LINQQueriesDemo.Models;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false)
    .AddUserSecrets<Program>()
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection")!;
var password = configuration["Database:Password"]!;

connectionString = connectionString.Replace("{PASSWORD}", password);

using var context = new ApplicationDbContext(connectionString);

context.Database.EnsureCreated();

if (!context.Products.Any())
{
    context.Products.AddRange(
        new Product { Name = "Laptop", Category = "Electronics", Price = 70000, Stock = 15 },
        new Product { Name = "Mouse", Category = "Electronics", Price = 800, Stock = 50 },
        new Product { Name = "Keyboard", Category = "Electronics", Price = 1500, Stock = 25 },
        new Product { Name = "Chair", Category = "Furniture", Price = 5500, Stock = 10 },
        new Product { Name = "Desk", Category = "Furniture", Price = 12000, Stock = 5 }
    );

    context.SaveChanges();
}

Console.WriteLine("===== LINQ Queries =====");

Console.WriteLine($"\nTotal Products: {context.Products.Count()}");

Console.WriteLine($"\nAny Product Available? {context.Products.Any()}");

Console.WriteLine("\nProducts Price > 5000");

foreach (var p in context.Products.Where(p => p.Price > 5000))
    Console.WriteLine($"{p.Name} - {p.Price}");

Console.WriteLine("\nOrdered By Price");

foreach (var p in context.Products.OrderBy(p => p.Price))
    Console.WriteLine($"{p.Name} - {p.Price}");

Console.WriteLine($"\nMaximum Price : {context.Products.Max(p => p.Price)}");
Console.WriteLine($"Minimum Price : {context.Products.Min(p => p.Price)}");
Console.WriteLine($"Average Price : {context.Products.Average(p => p.Price)}");
Console.WriteLine($"Total Stock   : {context.Products.Sum(p => p.Stock)}");

Console.WriteLine("\nFirst Product");

var first = context.Products.First();

Console.WriteLine($"{first.Name}");

Console.WriteLine("\nSkip 2 Take 2");

foreach (var p in context.Products.Skip(2).Take(2))
    Console.WriteLine(p.Name);

Console.WriteLine("\nGrouped By Category");

var groups = context.Products
    .GroupBy(p => p.Category);

foreach (var group in groups)
{
    Console.WriteLine($"\n{group.Key}");

    foreach (var p in group)
        Console.WriteLine($"  {p.Name}");
}
