using Moq;
using NUnit.Framework;

namespace MoqDemo.DatabaseMock
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        [Test]
        public void GetEmployee_ReturnsEmployeeName()
        {
            var repositoryMock = new Mock<IEmployeeRepository>();

            repositoryMock
                .Setup(r => r.GetEmployeeName(1))
                .Returns("Jaswanth");

            var service =
                new EmployeeService(repositoryMock.Object);

            var result = service.GetEmployee(1);

            Assert.AreEqual("Jaswanth", result);

            repositoryMock.Verify(
                r => r.GetEmployeeName(1),
                Times.Once);
        }
    }
}
