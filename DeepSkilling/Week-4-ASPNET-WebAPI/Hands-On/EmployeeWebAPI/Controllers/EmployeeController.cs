using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static readonly List<Employee> employees =
    [
        new Employee
        {
            Id = 1,
            Name = "John",
            Department = "IT",
            Salary = 50000
        },
        new Employee
        {
            Id = 2,
            Name = "Alice",
            Department = "HR",
            Salary = 45000
        }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Employee>> GetEmployees()
    {
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> GetEmployee(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        return Ok(employee);
    }
    [HttpPost]
public ActionResult<Employee> AddEmployee(Employee employee)
{
    employee.Id = employees.Count == 0 ? 1 : employees.Max(e => e.Id) + 1;
    employees.Add(employee);

    return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
}
[HttpPut("{id}")]
public IActionResult UpdateEmployee(int id, Employee updatedEmployee)
{
    var employee = employees.FirstOrDefault(e => e.Id == id);

    if (employee == null)
        return NotFound();

    employee.Name = updatedEmployee.Name;
    employee.Department = updatedEmployee.Department;
    employee.Salary = updatedEmployee.Salary;

    return NoContent();
}
[HttpDelete("{id}")]
public IActionResult DeleteEmployee(int id)
{
    var employee = employees.FirstOrDefault(e => e.Id == id);

    if (employee == null)
        return NotFound();

    employees.Remove(employee);

    return NoContent();
}
}
