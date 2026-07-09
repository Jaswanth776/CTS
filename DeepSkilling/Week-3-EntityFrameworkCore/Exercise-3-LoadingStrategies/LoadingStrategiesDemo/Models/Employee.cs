using System.ComponentModel.DataAnnotations;

namespace LoadingStrategiesDemo.Models;

public class Employee
{
    public int EmployeeId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int DepartmentId { get; set; }

    public Department Department { get; set; } = null!;
}
