using System;

namespace NUnitDemo.UrlParserTests
{
    public class UrlParser
    {
        public string GetHostName(string url)
        {
            Uri uri = new Uri(url);
            return uri.Host;
        }
    }
}
