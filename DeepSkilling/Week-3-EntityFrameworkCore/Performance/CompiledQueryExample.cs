using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFrameworkCoreDemo.Performance
{
    public class CompiledQueryExample
    {
        private static readonly Func<ApplicationDbContext, decimal, IQueryable<Employee>>
            HighSalaryEmployees =
                EF.CompileQuery(
                    (ApplicationDbContext context, decimal salary) =>
                        context.Employees.Where(e => e.Salary > salary)
                );
    }
}
