using Microsoft.Extensions.Configuration;

namespace Sysqa.Demo.SkyPoints.Utilities
{
    public static class ConfigurationFactory
    {
        internal static IConfiguration GetConfiguration()
        {

            var builder = new ConfigurationBuilder().SetBasePath("C:\\CodeRepo\\Sysqa.Demo.Appium\\Sysqa.Demo.SkyPoints\\Sysqa.Demo.SkyPoints").AddJsonFile("settings.json");

            return builder.Build();
        }



    }
}
