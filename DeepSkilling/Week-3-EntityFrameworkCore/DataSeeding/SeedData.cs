using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreDemo.DataSeeding
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Jaswanth",
                    Department = "IT",
                    Salary = 50000
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Rahul",
                    Department = "HR",
                    Salary = 45000
                }
            );
        }
    }
}
