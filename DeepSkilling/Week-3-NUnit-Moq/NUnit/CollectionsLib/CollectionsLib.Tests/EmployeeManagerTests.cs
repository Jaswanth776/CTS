using NUnit.Framework;
using CollectionsLib;
using System.Linq;

namespace CollectionsLib.Tests;

[TestFixture]
public class EmployeeManagerTests
{
    private EmployeeManager manager;

    [SetUp]
    public void Setup()
    {
        manager = new EmployeeManager();
    }

    [Test]
    public void GetEmployees_ShouldReturnFourEmployees()
    {
        var employees = manager.GetEmployees();

        Assert.That(employees, Is.Not.Null);
        Assert.That(employees.Count, Is.EqualTo(4));
    }

    [Test]
    public void GetEmployees_FirstEmployee_ShouldBeJohn()
    {
        var employees = manager.GetEmployees();

        Assert.That(employees.First().EmpName, Is.EqualTo("John"));
    }

    [Test]
    public void GetEmployees_ShouldContainEmployee100()
    {
        var employees = manager.GetEmployees();

        Assert.That(employees.Any(e => e.EmpId == 100), Is.True);
    }

    [Test]
    public void GetEmployeesWhoJoinedInPreviousYears_ShouldReturnEmployees()
    {
        var employees = manager.GetEmployeesWhoJoinedInPreviousYears();

        Assert.That(employees.Count, Is.EqualTo(4));
    }

    [Test]
    public void AllReturnedEmployees_ShouldHaveValidJoiningDate()
    {
        var employees = manager.GetEmployeesWhoJoinedInPreviousYears();

        Assert.That(employees.All(e => e.DOJ < System.DateTime.Now), Is.True);
    }

    [TearDown]
    public void Cleanup()
    {
        manager = null!;
    }
}