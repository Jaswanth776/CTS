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

Console.WriteLine("Updating Laptop...\n");

var laptop = context.Products
    .FirstOrDefault(p => p.Name == "Laptop");

if (laptop != null)
{
    laptop.Price = 70000;
    laptop.Stock = 15;

    context.SaveChanges();

    Console.WriteLine("Product updated successfully.\n");
}

Console.WriteLine("Products After Update");
Console.WriteLine("---------------------");

var updatedProducts = context.Products
    .OrderBy(p => p.ProductId)
    .ToList();

foreach (var product in updatedProducts)
{
    Console.WriteLine($"ID    : {product.ProductId}");
    Console.WriteLine($"Name  : {product.Name}");
    Console.WriteLine($"Price : {product.Price}");
    Console.WriteLine($"Stock : {product.Stock}");
    Console.WriteLine();
}

Console.WriteLine("Deleting Mouse...\n");

var mouse = context.Products
    .FirstOrDefault(p => p.Name == "Mouse");

if (mouse != null)
{
    context.Products.Remove(mouse);
    context.SaveChanges();

    Console.WriteLine("Product deleted successfully.\n");
}

Console.WriteLine("Products After Delete");
Console.WriteLine("---------------------");

var remainingProducts = context.Products
    .OrderBy(p => p.ProductId)
    .ToList();

foreach (var product in remainingProducts)
{
    Console.WriteLine($"ID    : {product.ProductId}");
    Console.WriteLine($"Name  : {product.Name}");
    Console.WriteLine($"Price : {product.Price}");
    Console.WriteLine($"Stock : {product.Stock}");
    Console.WriteLine();
}

Console.WriteLine("LINQ Query Examples");
Console.WriteLine("-------------------");

Console.WriteLine($"\nTotal Products : {context.Products.Count()}");

Console.WriteLine($"\nAny Products? : {context.Products.Any()}");

var expensiveProducts = context.Products
    .Where(p => p.Price > 1000)
    .ToList();

Console.WriteLine("\nProducts with Price > 1000");

foreach (var product in expensiveProducts)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}

var firstProduct = context.Products.FirstOrDefault();

if (firstProduct != null)
{
    Console.WriteLine($"\nFirst Product : {firstProduct.Name}");
}

var orderedProducts = context.Products
    .OrderBy(p => p.Name)
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToList();

Console.WriteLine("\nOrdered Products");

foreach (var product in orderedProducts)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}
