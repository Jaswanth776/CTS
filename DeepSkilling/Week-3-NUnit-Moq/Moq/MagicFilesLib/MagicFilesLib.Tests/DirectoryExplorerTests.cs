using Moq;
using NUnit.Framework;
using MagicFilesLib;

namespace MagicFilesLib.Tests;

[TestFixture]
public class DirectoryExplorerTests
{
    [Test]
    public void GetTotalFiles_ReturnsCorrectFileCount()
    {
        var mockDirectory = new Mock<IDirectoryExplorer>();

        mockDirectory
            .Setup(x => x.GetFiles(It.IsAny<string>()))
            .Returns(new List<string>
            {
                "File1.txt",
                "File2.txt",
                "File3.txt"
            });

        var explorer = new DirectoryExplorer(mockDirectory.Object);

        int result = explorer.GetTotalFiles("C:\\Temp");

        Assert.That(result, Is.EqualTo(3));
    }
}
