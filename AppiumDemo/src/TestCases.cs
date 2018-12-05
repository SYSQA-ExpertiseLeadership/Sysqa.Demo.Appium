using AppiumDemo.src.PageObject.System;
using AppiumDemo.src.Utillity;
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
        [TearDown]
        public void close()
        {
            Driver.Instance.Dispose();

        }

        [Test]
        public void First_real_test()
        {
            var App = new AppUnderTest()
                .NavigateToCalendar()
                .ClickAround();
        }

        [Test]
        public void ShouldSetTitle()
        {
            var app = new AppUnderTest()
                .NavigateToCalendar()
                .OpenAddScreen()
                .MakeItem("TestTitel123");

            Assert.That(app.Title.Equals("TestTitel123"));

        }
        [Test]
        public void LatestTaskShouldBeOnTop()
        {
            var app = new AppUnderTest().NavigateToTasksPage()
                .OpenAddTasks()
                .AddTask("Taks1")
                .AddTask("Taks2")
                .GotToFitrstTask();

            Assert.That(app.Title.Equals("Taks2"));

        }

    }
}
