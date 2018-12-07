using NUnit.Framework;
using System;
using System.Drawing.Imaging;
using System.IO;

namespace Sysqa.Demo.SkyPoints.Utilities
{
    public class BaseTest
    {
        [TearDown]
        protected void EndTestCase()
        {
            LogErrors();
            Driver.CleanUp();
        }

        protected void LogErrors()
        {
            var TestName = $"{TestContext.CurrentContext.Test.Name}@{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}";
            MakeScreenShot(TestName);
        }

        protected void MakeScreenShot(string name)
        {
            Directory.CreateDirectory(Settings.TestSettingsInstance.LogFolder);

            var screen = Driver.Instance.GetScreenshot();
            screen.SaveAsFile($"{Settings.TestSettingsInstance.LogFolder}{name}.png", ImageFormat.Png);
        }
    }
}
