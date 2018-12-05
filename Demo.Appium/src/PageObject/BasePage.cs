using AppiumDemo.src.Utillity;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AppiumDemo.src.PageObject
{
    public class BasePage
    {
        private readonly WebDriverWait waitController;

        public BasePage() => waitController = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(50));

        public IWebElement WaitForElement(IWebElement element)
        {

            return waitController.Until(__ => element);
        }
    }
}
