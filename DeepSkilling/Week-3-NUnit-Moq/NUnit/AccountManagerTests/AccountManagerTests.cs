using NUnit.Framework;
using System;

namespace NUnitDemo.AccountManagerTests
{
    [TestFixture]
    public class AccountManagerTests
    {
        private AccountManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new AccountManager();
        }

        [Test]
        public void ValidLogin_ReturnsTrue()
        {
            Assert.IsTrue(
                manager.Login("admin", "admin123"));
        }

        [Test]
        public void InvalidLogin_ReturnsFalse()
        {
            Assert.IsFalse(
                manager.Login("user", "wrong"));
        }

        [Test]
        public void EmptyUsername_ThrowsException()
        {
            Assert.Throws<ArgumentException>(
                () => manager.Login("", "admin123"));
        }

        [Test]
        public void EmptyPassword_ThrowsException()
        {
            Assert.Throws<ArgumentException>(
                () => manager.Login("admin", ""));
        }
    }
}
