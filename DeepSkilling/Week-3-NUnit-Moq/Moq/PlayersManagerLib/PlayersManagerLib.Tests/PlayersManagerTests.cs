using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayersManagerLib.Tests;

[TestFixture]
public class PlayersManagerTests
{
    [Test]
    public void GetPlayers_ReturnsPlayerList()
    {
        var mockMapper = new Mock<IPlayerMapper>();

        var players = new List<Player>
        {
            new Player { Id = 1, Name = "Virat" },
            new Player { Id = 2, Name = "Rohit" },
            new Player { Id = 3, Name = "Dhoni" }
        };

        mockMapper
            .Setup(x => x.GetPlayers())
            .Returns(players);

        var manager = new PlayersManager(mockMapper.Object);

        var result = manager.GetPlayers();

        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result[0].Name, Is.EqualTo("Virat"));

        mockMapper.Verify(x => x.GetPlayers(), Times.Once);
    }
}
