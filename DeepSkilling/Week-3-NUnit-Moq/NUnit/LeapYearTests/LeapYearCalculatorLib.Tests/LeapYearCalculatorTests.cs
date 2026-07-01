using NUnit.Framework;
using LeapYearCalculatorLib;

namespace LeapYearCalculatorLib.Tests;

[TestFixture]
public class LeapYearCalculatorTests
{
    private LeapYearCalculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new LeapYearCalculator();
    }

    [TestCase(2024, 1)]
    [TestCase(2000, 1)]
    [TestCase(1900, 0)]
    [TestCase(2023, 0)]
    [TestCase(1752, -1)]
    [TestCase(10000, -1)]
    public void IsLeapYear_ReturnsExpectedResult(int year, int expected)
    {
        int result = calculator.IsLeapYear(year);

        Assert.That(result, Is.EqualTo(expected));
    }

    [TearDown]
    public void Cleanup()
    {
        calculator = null!;
    }
}