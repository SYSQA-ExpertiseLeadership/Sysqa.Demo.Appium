using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace AppiumDemo
{
    [TestFixture]
    public class TestCases
    {
        AndroidDriver<AndroidElement> driver;
        DesiredCapabilities cap;

        [SetUp]
        public void init()
        {
            cap = new DesiredCapabilities();
            cap.SetCapability("platformName","Android");
            cap.SetCapability("udid", "169.254.138.177:5555");
            cap.SetCapability("deviceName", $"7'' KitKat (4.4) XHDPI Tablet");
            cap.SetCapability("app", "C:\\Users\\Genuit MHG\\Downloads\\Task.apk");
            cap.SetCapability("fullReset", "false");
            cap.SetCapability("appWaitActivity", "org.dmfs.tasks.TaskListActivity");
            cap.SetCapability("automationName", "appium");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"),cap);

        }
        [TearDown]
            public void close()
        {
            driver.Quit();

        }

        [Test]
        public void Test1()
        {
            AndroidElement elemet = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[2]/android.widget.ImageView"));
            AndroidElement elemet2 = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[5]/android.widget.ImageView"));

            for (int i = 0; i < 5; i++)
            {
                elemet.Click();
                Thread.Sleep(200);
                elemet2.Click();
                Thread.Sleep(200);
            }

        }

    }
}
