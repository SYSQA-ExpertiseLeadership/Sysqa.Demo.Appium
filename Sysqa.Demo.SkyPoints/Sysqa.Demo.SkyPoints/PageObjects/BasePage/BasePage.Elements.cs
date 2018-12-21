using OpenQA.Selenium;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class BasePage
    {
        private IWebElement pageTitle { get { return TryFind(By.Id("nl.airmiles.app:id/app_title")); } }
    }
}
