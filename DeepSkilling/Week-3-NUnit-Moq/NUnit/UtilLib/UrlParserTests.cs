using NUnit.Framework;

namespace NUnitDemo.UrlParserTests
{
    [TestFixture]
    public class UrlParserTests
    {
        private UrlParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlParser();
        }

        [Test]
        public void GetHostName_ReturnsCorrectHost()
        {
            string host =
                parser.GetHostName("https://www.cognizant.com");

            Assert.That(host, Is.EqualTo("www.cognizant.com"));
        }

        [Test]
        public void GetHostName_GoogleHost()
        {
            string host =
                parser.GetHostName("https://www.google.com");

            Assert.That(host, Is.EqualTo("www.google.com"));
        }
    }
}
