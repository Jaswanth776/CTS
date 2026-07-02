using Moq;
using NUnit.Framework;
using ConverterLib;

namespace ConverterLib.Tests;

[TestFixture]
public class CurrencyConverterTests
{
    [Test]
    public void ConvertAmount_ReturnsConvertedValue()
    {
        var mockConverter = new Mock<ICurrencyConverter>();

        mockConverter
            .Setup(x => x.Convert(100, "USD", "INR"))
            .Returns(8300);

        var converter = new CurrencyConverter(mockConverter.Object);

        double result = converter.ConvertAmount(100, "USD", "INR");

        Assert.That(result, Is.EqualTo(8300));

        mockConverter.Verify(
            x => x.Convert(100, "USD", "INR"),
            Times.Once);
    }
}
