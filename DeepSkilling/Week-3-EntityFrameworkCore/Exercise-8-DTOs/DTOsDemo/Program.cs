using Microsoft.Extensions.Configuration;
using DTOsDemo.Data;
using DTOsDemo.DTOs;
using DTOsDemo.Models;

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
        new Product
        {
            Name = "Laptop",
            Category = "Electronics",
            Price = 70000,
            Stock = 15
        },
        new Product
        {
            Name = "Mouse",
            Category = "Electronics",
            Price = 800,
            Stock = 50
        },
        new Product
        {
            Name = "Chair",
            Category = "Furniture",
            Price = 5500,
            Stock = 10
        });

    context.SaveChanges();
}

Console.WriteLine("Products using DTO");
Console.WriteLine("------------------");

var products = context.Products
    .Select(p => new ProductDTO
    {
        Name = p.Name,
        Price = p.Price
    })
    .ToList();

foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
