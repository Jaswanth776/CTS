using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ConcurrencyDemo.Data;
using ConcurrencyDemo.Models;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .AddUserSecrets<Program>()
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection")!;
var password = configuration["Database:Password"]!;

connectionString = connectionString.Replace("{PASSWORD}", password);

using var context1 = new ApplicationDbContext(connectionString);
using var context2 = new ApplicationDbContext(connectionString);

if (!context1.Products.Any())
{
    context1.Products.Add(new Product
    {
        Name = "Laptop",
        Price = 70000,
        Stock = 10
    });

    context1.SaveChanges();
}

var productContext1 = context1.Products.First();

Console.WriteLine("Original Product");
Console.WriteLine($"Name  : {productContext1.Name}");
Console.WriteLine($"Price : {productContext1.Price}");
Console.WriteLine();

var productContext2 = context2.Products.First();

productContext2.Price = 75000;

context2.SaveChanges();

Console.WriteLine("Second context updated the product.");
Console.WriteLine();

productContext1.Price = 80000;

try
{
    Console.WriteLine("First context attempting update...");
    context1.SaveChanges();
    Console.WriteLine("Update successful.");
}
catch (DbUpdateConcurrencyException)
{
    Console.WriteLine("Concurrency conflict detected!");
}
