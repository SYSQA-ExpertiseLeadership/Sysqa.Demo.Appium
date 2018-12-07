using OpenQA.Selenium;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class MyOffersPage : BasePage
    {
        private IWebElement emptyText {get{ return TryFind(By.Id("nl.airmiles.app:id/emptyText")); } }
    }
}
