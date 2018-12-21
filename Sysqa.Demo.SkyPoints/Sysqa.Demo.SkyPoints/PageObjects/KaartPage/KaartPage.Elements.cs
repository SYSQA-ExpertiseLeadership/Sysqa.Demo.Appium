using OpenQA.Selenium;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class KaartPage :BasePage
    {
        private IWebElement cardNumberField { get { return TryFind(By.Id("nl.airmiles.app:id/editText1")); } }
        private IWebElement cardNumberSubmit { get { return TryFind(By.Id("nl.airmiles.app:id/button2")); } }

    }
}
