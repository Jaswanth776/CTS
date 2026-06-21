using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkCoreDemo.LoadingStrategies
{
    public class EagerLoading
    {
        public void Load(ApplicationDbContext context)
        {
            var employees = context.Employees
                                   .Include(e => e.Department)
                                   .ToList();
        }
    }
}
