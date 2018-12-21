using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using Sysqa.Demo.SkyPoints.Utilities;
using System;
using System.Collections.ObjectModel;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class BasePage
    {
        protected ReadOnlyCollection<AndroidElement> TryFindAll(By selector)
        {
            return Wait.Until(_ => Driver.Instance.FindElements(selector));
        }
        public IWebElement TryFind(By selector)
        {
            return TryFind(selector, Wait);
        }
        public IWebElement TryFind(By selector, WebDriverWait wait)
        {
            return wait.Until(_ => Driver.Instance.FindElement(selector));
        }

        protected bool ElementExists(By by)
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
