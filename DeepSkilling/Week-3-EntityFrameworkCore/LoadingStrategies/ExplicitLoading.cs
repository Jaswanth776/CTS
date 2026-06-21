using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkCoreDemo.LoadingStrategies
{
    public class ExplicitLoading
    {
        public void Load(ApplicationDbContext context)
        {
            var employee = context.Employees.FirstOrDefault();

            if (employee != null)
            {
                context.Entry(employee).Reload();
            }
        }
    }
}
