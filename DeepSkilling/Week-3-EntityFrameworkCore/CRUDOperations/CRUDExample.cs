using System;
using System.Linq;
using EntityFrameworkCoreDemo.Models;
using EntityFrameworkCoreDemo.DbContext;

namespace EntityFrameworkCoreDemo.CRUDOperations
{
    public class CRUDExample
    {
        public void Run(ApplicationDbContext context)
        {
            var employee = new Employee
            {
                Name = "Jaswanth",
                Department = "IT",
                Salary = 50000
            };

            context.Employees.Add(employee);
            context.SaveChanges();

            var employees = context.Employees.ToList();

            var firstEmployee = context.Employees.FirstOrDefault();

            if (firstEmployee != null)
            {
                firstEmployee.Salary = 55000;
                context.SaveChanges();
            }

            if (firstEmployee != null)
            {
                context.Employees.Remove(firstEmployee);
                context.SaveChanges();
            }
        }
    }
}
