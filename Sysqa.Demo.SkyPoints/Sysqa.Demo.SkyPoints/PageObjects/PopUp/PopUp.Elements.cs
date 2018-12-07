using OpenQA.Selenium;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class PopUp :BasePage
    {
        private IWebElement title { get { return TryFind(By.Id("nl.airmiles.app:id/alertTitle")); } }
        private IWebElement yesButton { get { return TryFind(By.Id("android:id/button3")); } }
        private IWebElement noButton { get { return TryFind(By.Id("android:id/button2")); } }
    }
}
