using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkCoreDemo.Performance
{
    public class AsNoTrackingExample
    {
        public void Run(ApplicationDbContext context)
        {
            var employees = context.Employees
                                   .AsNoTracking()
                                   .ToList();
        }
    }
}
