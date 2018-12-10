using NUnit.Framework;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace Sysqa.Demo.SkyPoints.Utilities
{
    public class BaseTest
    {
        [OneTimeSetUp]

        public void SettupLogger() { }

        [OneTimeTearDown]
        public async Task endLogger()
        {
            Directory.CreateDirectory($"{Settings.TestSettingsInstance.LogFolder}\\logs");
            var fileCreate = File.Create($"{Settings.TestSettingsInstance.LogFolder}\\logs\\TestRun@{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.txt");
            fileCreate.Dispose();

            StreamWriter file = new StreamWriter(@"C:\TestTestFolder\WriteLines2.txt");
            foreach (var logLine in TestLogger.Log)
            {
                await file.WriteLineAsync("asd");
            }

            file.Close();
        }

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
            Directory.CreateDirectory($"{Settings.TestSettingsInstance.LogFolder}\\Screenshots");

            var screen = Driver.Instance.GetScreenshot();
            screen.SaveAsFile($"{Settings.TestSettingsInstance.LogFolder}\\Screenshots\\{name}.png", ImageFormat.Png);
        }
    }
}
