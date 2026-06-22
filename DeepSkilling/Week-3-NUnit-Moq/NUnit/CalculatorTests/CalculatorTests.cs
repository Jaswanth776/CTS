using NUnit.Framework;

namespace NUnitDemo.CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            int result = calculator.Add(10, 20);

            Assert.AreEqual(30, result);
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }
    }
}
