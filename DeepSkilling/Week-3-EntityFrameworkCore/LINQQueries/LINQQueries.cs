using System;
using System.Linq;
using EntityFrameworkCoreDemo.DbContext;

namespace EntityFrameworkCoreDemo.LinqQueries
{
    public class LINQQueries
    {
        public void Run(ApplicationDbContext context)
        {
            var highSalaryEmployees =
                context.Employees
                .Where(e => e.Salary > 40000)
                .ToList();

            var sortedEmployees =
                context.Employees
                .OrderBy(e => e.Name)
                .ToList();

            var employeeNames =
                context.Employees
                .Select(e => e.Name)
                .ToList();

            var averageSalary =
                context.Employees
                .Average(e => e.Salary);

            Console.WriteLine($"Average Salary: {averageSalary}");
        }
    }
}
