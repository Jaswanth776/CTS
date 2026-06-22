using NUnit.Framework;

namespace NUnitDemo.LeapYearTests
{
    [TestFixture]
    public class LeapYearTests
    {
        private LeapYearChecker checker;

        [SetUp]
        public void Setup()
        {
            checker = new LeapYearChecker();
        }

        [TestCase(2024, true)]
        [TestCase(2023, false)]
        [TestCase(2000, true)]
        [TestCase(1900, false)]
        public void IsLeapYear_Test(int year, bool expected)
        {
            Assert.AreEqual(
                expected,
                checker.IsLeapYear(year));
        }
    }
}
