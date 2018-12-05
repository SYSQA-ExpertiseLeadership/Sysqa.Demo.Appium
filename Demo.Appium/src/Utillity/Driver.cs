using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.ObjectModel;

namespace AppiumDemo.src.Utillity
{
    public static class Driver
    {
        internal static IWebDriver _driverInstance;
        private static DesiredCapabilities cap;

        internal static IWebDriver Instance
        {
            get
            {
                if (_driverInstance == null)
                {
                    cap = new DesiredCapabilities();
                    cap.SetCapability("platformName", "Android");
                    cap.SetCapability("udid", "169.254.138.177:5555");
                    cap.SetCapability("deviceName", $"7'' KitKat (4.4) XHDPI Tablet");
                    cap.SetCapability("app", "C:\\Users\\Genuit MHG\\Downloads\\Task.apk");
                    cap.SetCapability("fullReset", "false");
                    cap.SetCapability("appWaitActivity", "org.dmfs.tasks.TaskListActivity");
                    cap.SetCapability("automationName", "appium");

                    _driverInstance = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
                }
                return _driverInstance;
            }
        }

        public static ReadOnlyCollection<IWebElement>TryFindElements(By by)
        {
            try
            {
                return Instance.FindElements(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }

        }

        public static IWebElement TryFindElement(By by)
        {
            try
            {
                return Instance.FindElement(by);

            }
            catch (NoSuchElementException)
            {
                return null;
            }

        }
    }
}
