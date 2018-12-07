using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Sysqa.Demo.SkyPoints.Utilities
{
    public static class Settings
    {
        private static TestSettings _browserInstance;
        private static User _userInstance;
        internal static TestSettings TestSettingsInstance
        {
            get
            {
                if (_browserInstance == null)
                {
                    _browserInstance = ConfigurationFactory.GetConfiguration()
                    .GetSection("TestSettings").Get<TestSettings>();
                };
                return _browserInstance;

            }
        }

        internal static User UserInstance
        {
            get
            {
                if (_userInstance == null)
                {
                    _userInstance = ConfigurationFactory.GetConfiguration()
                    .GetSection("User").Get<User>();
                };
                return _userInstance;

            }
        }
    }

}
