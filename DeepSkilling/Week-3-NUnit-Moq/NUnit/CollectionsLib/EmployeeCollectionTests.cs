using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitDemo.CollectionTests
{
    [TestFixture]
    public class EmployeeCollectionTests
    {
        private List<Employee> employees;

        [SetUp]
        public void Setup()
        {
            employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Jaswanth" },
                new Employee { Id = 2, Name = "Rahul" },
                new Employee { Id = 3, Name = "Priya" }
            };
        }

        [Test]
        public void EmployeeNames_AreUnique()
        {
            CollectionAssert.AllItemsAreUnique(
                employees.Select(e => e.Name));
        }

        [Test]
        public void EmployeeCollection_ContainsRahul()
        {
            CollectionAssert.Contains(
                employees.Select(e => e.Name),
                "Rahul");
        }

        [Test]
        public void EmployeeCollection_HasNoNullValues()
        {
            CollectionAssert.AllItemsAreNotNull(employees);
        }
    }
}
