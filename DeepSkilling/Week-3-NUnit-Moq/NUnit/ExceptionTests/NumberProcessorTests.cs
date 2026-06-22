using NUnit.Framework;
using System;

namespace NUnitDemo.ExceptionTests
{
    [TestFixture]
    public class NumberProcessorTests
    {
        private NumberProcessor processor;

        [SetUp]
        public void Setup()
        {
            processor = new NumberProcessor();
        }

        [Test]
        public void SquareRoot_ValidNumber()
        {
            Assert.AreEqual(
                5,
                processor.SquareRoot(25));
        }

        [Test]
        public void SquareRoot_NegativeNumber_ThrowsException()
        {
            Assert.Throws<ArgumentException>(
                () => processor.SquareRoot(-25));
        }
    }
}
