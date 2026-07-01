using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests;

[TestFixture]
public class CalculatorTests
{
    private SimpleCalculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new SimpleCalculator();
    }

    [TestCase(10, 20, 30)]
    [TestCase(5, 5, 10)]
    [TestCase(-2, 2, 0)]
    public void Addition_ReturnsExpected(double a, double b, double expected)
    {
        Assert.That(calculator.Addition(a, b), Is.EqualTo(expected));
    }

    [TestCase(20, 10, 10)]
    [TestCase(10, 20, -10)]
    public void Subtraction_ReturnsExpected(double a, double b, double expected)
    {
        Assert.That(calculator.Subtraction(a, b), Is.EqualTo(expected));
    }

    [TestCase(10, 5, 50)]
    [TestCase(-2, 4, -8)]
    public void Multiplication_ReturnsExpected(double a, double b, double expected)
    {
        Assert.That(calculator.Multiplication(a, b), Is.EqualTo(expected));
    }

    [TestCase(20, 4, 5)]
    [TestCase(15, 3, 5)]
    public void Division_ReturnsExpected(double a, double b, double expected)
    {
        Assert.That(calculator.Division(a, b), Is.EqualTo(expected));
    }

    [Test]
    public void Division_ByZero_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => calculator.Division(10, 0));
    }

    [Test]
    public void AddAndClear_ResultShouldBecomeZero()
    {
        calculator.Addition(5, 5);

        Assert.That(calculator.GetResult, Is.EqualTo(10));

        calculator.AllClear();

        Assert.That(calculator.GetResult, Is.EqualTo(0));
    }

    [TearDown]
    public void Cleanup()
    {
        calculator = null;
    }
}