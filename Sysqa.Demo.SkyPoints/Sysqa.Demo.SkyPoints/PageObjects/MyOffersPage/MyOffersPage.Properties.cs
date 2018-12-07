using OpenQA.Selenium;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class MyOffersPage : BasePage
    {
        public bool IsLoaded { get { return emptyText.Displayed; } }
        public bool hasOffers { get { return !ElementExists(By.Id("nl.airmiles.app:id/emptyText")); } }
    }
}
