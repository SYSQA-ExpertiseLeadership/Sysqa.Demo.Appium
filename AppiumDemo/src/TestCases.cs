using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;

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
            cap.SetCapability("deviceName", $"5\" Marshmallow(6.0.0) XXHDPI Phone");
            cap.SetCapability("platformVersion", "6.0.0");
            cap.SetCapability("udid", "169.254.76.233:5555");
            cap.SetCapability("fullReset", "True");
            //cap.SetCapability("appPackage", "com.andriod.dailer");
            cap.SetCapability(MobileCapabilityType.App,"Browser");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"),cap);

        }
        [TearDown]
            public void close()
        {
            driver.Close();

        }

        [Test]
        public void Test1()
        {
            IWebElement x = driver.FindElementByName("asd");

        }

    }
}
