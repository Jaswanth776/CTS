using NUnit.Framework;
using UserManagerLib;
using System;

namespace UserManagerLib.Tests;

[TestFixture]
public class UserTests
{
    private User user;

    [SetUp]
    public void Setup()
    {
        user = new User();
    }

    [Test]
    public void ValidatePANCardNumber_ValidPAN_ReturnsValid()
    {
        var result = user.ValidatePANCardNumber("ABCDE1234F");

        Assert.That(result, Is.EqualTo("Valid"));
    }

    [Test]
    public void ValidatePANCardNumber_NullPAN_ThrowsNullReferenceException()
    {
        Assert.Throws<NullReferenceException>(() =>
            user.ValidatePANCardNumber(null!));
    }

    [Test]
    public void ValidatePANCardNumber_EmptyPAN_ThrowsNullReferenceException()
    {
        Assert.Throws<NullReferenceException>(() =>
            user.ValidatePANCardNumber(""));
    }

    [Test]
    public void ValidatePANCardNumber_ShortPAN_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() =>
            user.ValidatePANCardNumber("ABC123"));
    }

    [Test]
    public void ValidatePANCardNumber_LongPAN_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() =>
            user.ValidatePANCardNumber("ABCDEFGHIJK"));
    }

    [TearDown]
    public void Cleanup()
    {
        user = null!;
    }
}