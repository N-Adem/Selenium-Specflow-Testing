using System;
using System.Configuration;


namespace Selenium_Test1
{
    public static class AppConfigReader
    {
        public static readonly string baseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string signInPageUrl = ConfigurationManager.AppSettings["signinipage_url"];
    }
}
