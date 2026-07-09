using Microsoft.Extensions.Configuration;
using DataSeedingDemo.Data;

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

Console.WriteLine("Seeded Products");
Console.WriteLine("----------------");

foreach (var product in context.Products.OrderBy(p => p.ProductId))
{
    Console.WriteLine($"{product.ProductId}  {product.Name}  {product.Category}  {product.Price}  {product.Stock}");
}
