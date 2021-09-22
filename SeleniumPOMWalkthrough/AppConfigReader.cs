using System;
using System.Configuration;

namespace SeleniumPOMWalkthrough
{
    //This class is created to be a global reader for the app.config attributes
    public static class AppConfigReader
    {
        public static readonly string BaseURL = ConfigurationManager.AppSettings["base_url"];
        public static readonly string UserPageUrl = ConfigurationManager.AppSettings["userpage_url"];
    }
}
