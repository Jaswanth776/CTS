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

var product1 = new Product
{
    Name = "Laptop",
    Price = 65000,
    Stock = 10
};

var product2 = new Product
{
    Name = "Mouse",
    Price = 750,
    Stock = 50
};

context.Products.Add(product1);
context.Products.Add(product2);

context.SaveChanges();

Console.WriteLine("Products inserted successfully.");
