using NUnit.Framework;
using UtilLib;
using System;

namespace UtilLib.Tests;

[TestFixture]
public class UrlHostNameParserTests
{
    private UrlHostNameParser parser;

    [SetUp]
    public void Setup()
    {
        parser = new UrlHostNameParser();
    }

    [Test]
    public void ParseHostName_HttpUrl_ReturnsHostName()
    {
        var result = parser.ParseHostName("http://www.google.com/search");

        Assert.That(result, Is.EqualTo("www.google.com"));
    }

    [Test]
    public void ParseHostName_HttpsUrl_ReturnsHostName()
    {
        var result = parser.ParseHostName("https://github.com/openai");

        Assert.That(result, Is.EqualTo("github.com"));
    }

    [Test]
    public void ParseHostName_InvalidProtocol_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() =>
            parser.ParseHostName("ftp://example.com"));
    }

    [Test]
    public void ParseHostName_InvalidProtocol_MessageMatches()
    {
        var ex = Assert.Throws<FormatException>(() =>
            parser.ParseHostName("smtp://mail.server.com"));

        Assert.That(ex!.Message, Is.EqualTo("Url is not in correct format"));
    }

    [TearDown]
    public void Cleanup()
    {
        parser = null!;
    }
}