using System.ComponentModel.DataAnnotations;

namespace LoadingStrategiesDemo.Models;

public class Department
{
    public int DepartmentId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
