using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LoadingStrategiesDemo.Data;
using LoadingStrategiesDemo.Models;

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

if (!context.Departments.Any())
{
    var it = new Department { Name = "IT" };
    var hr = new Department { Name = "HR" };

    context.Departments.AddRange(it, hr);
    context.SaveChanges();

    context.Employees.AddRange(
        new Employee
        {
            Name = "Alice",
            DepartmentId = it.DepartmentId
        },
        new Employee
        {
            Name = "Bob",
            DepartmentId = it.DepartmentId
        },
        new Employee
        {
            Name = "Charlie",
            DepartmentId = hr.DepartmentId
        });

    context.SaveChanges();
}

Console.WriteLine("===== Eager Loading =====");

var departments = context.Departments
    .Include(d => d.Employees)
    .ToList();

foreach (var department in departments)
{
    Console.WriteLine($"\nDepartment: {department.Name}");

    foreach (var employee in department.Employees)
    {
        Console.WriteLine($" - {employee.Name}");
    }
}

Console.WriteLine("\n===== Explicit Loading =====");

var firstDepartment = context.Departments.First();

context.Entry(firstDepartment)
       .Collection(d => d.Employees)
       .Load();

Console.WriteLine($"\nDepartment: {firstDepartment.Name}");

foreach (var employee in firstDepartment.Employees)
{
    Console.WriteLine($" - {employee.Name}");
}
