using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sysqa.Demo.SkyPoints.Utilities;
using System;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class BasePage
    {
        [TearDown]
        public void EndTestCase()
        {
            Driver.CleanUp();
        }


        public IWebElement TryFind(By selector)
        {
            return TryFind(selector, Wait);
        }
        public IWebElement TryFind(By selector, WebDriverWait wait)
        {
            return wait.Until(_ => Driver.Instance.FindElement(selector));
        }

        public bool ElementExists(By by)
        {
            try
            {
                TryFind(by,new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(3)));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }

        }
    }
}
