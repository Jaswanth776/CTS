using Moq;
using NUnit.Framework;

namespace MoqDemo.CurrencyConverterMock
{
    [TestFixture]
    public class CurrencyConverterTests
    {
        [Test]
        public void Convert_ReturnsConvertedAmount()
        {
            var currencyMock = new Mock<ICurrencyService>();

            currencyMock
                .Setup(c => c.GetExchangeRate("USD", "INR"))
                .Returns(83.50m);

            var converter =
                new CurrencyConverter(currencyMock.Object);

            decimal result =
                converter.Convert(10, "USD", "INR");

            Assert.AreEqual(835.00m, result);

            currencyMock.Verify(
                c => c.GetExchangeRate("USD", "INR"),
                Times.Once);
        }
    }
}
