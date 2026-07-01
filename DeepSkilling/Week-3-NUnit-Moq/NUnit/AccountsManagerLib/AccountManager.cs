using System;

namespace NUnitDemo.AccountManagerTests
{
    public class AccountManager
    {
        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username required");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password required");

            return username == "admin" &&
                   password == "admin123";
        }
    }
}
