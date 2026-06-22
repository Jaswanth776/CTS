using NUnit.Framework;
using System;

namespace NUnitDemo.ParameterizedTests
{
    [TestFixture]
    public class ParameterizedCalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(100, 200, 300)]
        public void Add_Test(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Add(a, b));
        }

        [TestCase(20, 10, 10)]
        [TestCase(15, 5, 10)]
        public void Subtract_Test(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Subtract(a, b));
        }

        [TestCase(5, 5, 25)]
        [TestCase(10, 2, 20)]
        public void Multiply_Test(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Multiply(a, b));
        }

        [TestCase(20, 5, 4)]
        [TestCase(100, 10, 10)]
        public void Divide_Test(int a, int b, int expected)
        {
            Assert.AreEqual(expected, calculator.Divide(a, b));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(
                () => calculator.Divide(10, 0));
        }
    }
}
