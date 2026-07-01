using NUnit.Framework;
using AccountsManagerLib;
using System;

namespace AccountsManagerLib.Tests;

[TestFixture]
public class AccountsManagerTests
{
    private AccountsManager manager;

    [SetUp]
    public void Setup()
    {
        manager = new AccountsManager();
    }

    [Test]
    public void ValidateUser_ValidUser11_ReturnsWelcomeMessage()
    {
        string result = manager.ValidateUser("user_11", "secret@user11");

        Assert.That(result, Is.EqualTo("Welcome user_11!!!"));
    }

    [Test]
    public void ValidateUser_ValidUser22_ReturnsWelcomeMessage()
    {
        string result = manager.ValidateUser("user_22", "secret@user22");

        Assert.That(result, Is.EqualTo("Welcome user_22!!!"));
    }

    [Test]
    public void ValidateUser_InvalidCredentials_ReturnsInvalidMessage()
    {
        string result = manager.ValidateUser("admin", "admin");

        Assert.That(result, Is.EqualTo("Invalid user id/password"));
    }

    [Test]
    public void ValidateUser_EmptyUserId_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() =>
            manager.ValidateUser("", "secret"));
    }

    [Test]
    public void ValidateUser_EmptyPassword_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() =>
            manager.ValidateUser("user_11", ""));
    }

    [Test]
    public void ValidateUser_NullUserId_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() =>
            manager.ValidateUser(null!, "secret"));
    }

    [Test]
    public void ValidateUser_NullPassword_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() =>
            manager.ValidateUser("user_11", null!));
    }

    [TearDown]
    public void Cleanup()
    {
        manager = null!;
    }
}