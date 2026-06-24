using Moq;
using NUnit.Framework;

namespace MoqDemo.FileSystemMock
{
    [TestFixture]
    public class FileReaderTests
    {
        [Test]
        public void GetFileContent_ReturnsExpectedContent()
        {
            var fileSystemMock = new Mock<IFileSystem>();

            fileSystemMock
                .Setup(x => x.ReadFile("test.txt"))
                .Returns("Hello World");

            var reader =
                new FileReader(fileSystemMock.Object);

            var result =
                reader.GetFileContent("test.txt");

            Assert.AreEqual(
                "Hello World",
                result);
        }
    }
}
