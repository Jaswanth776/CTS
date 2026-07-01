using NUnit.Framework;
using SeasonsLib;
using System.Collections;

namespace SeasonsLib.Tests;

[TestFixture]
public class SeasonTellerTests
{
    private SeasonTeller teller;

    [SetUp]
    public void Setup()
    {
        teller = new SeasonTeller();
    }

    public static IEnumerable SeasonData()
    {
        yield return new TestCaseData("January", "Winter");
        yield return new TestCaseData("February", "Spring");
        yield return new TestCaseData("April", "Summer");
        yield return new TestCaseData("July", "Monsoon");
        yield return new TestCaseData("October", "Autumn");
        yield return new TestCaseData("InvalidMonth", "Invalid Season");
    }

    [Test]
    [TestCaseSource(nameof(SeasonData))]
    public void DisplaySeasonBy_ReturnsExpectedSeason(string month, string expected)
    {
        var result = teller.DisplaySeasonBy(month);

        Assert.That(result, Is.EqualTo(expected));
    }

    [TearDown]
    public void Cleanup()
    {
        teller = null!;
    }
}