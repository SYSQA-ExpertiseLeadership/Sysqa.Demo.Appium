using OpenQA.Selenium;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class LoginPage :BasePage
    {
        private IWebElement logInButton { get { return TryFind(By.Id("nl.airmiles.app:id/loginbutton")); } }
        private IWebElement userNameField { get { return TryFind(By.Id("nl.airmiles.app:id/username")); } }
        private IWebElement passwordField { get { return TryFind(By.Id("nl.airmiles.app:id/password")); } }
    }
}
