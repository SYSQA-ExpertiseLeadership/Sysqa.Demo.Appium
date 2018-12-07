using OpenQA.Selenium;
using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class BasePage
    {
        public IWebElement TryFind(By selector)
        {
            return Wait.Until(_ => Driver.Instance.FindElement(selector));
        }
    }
}
