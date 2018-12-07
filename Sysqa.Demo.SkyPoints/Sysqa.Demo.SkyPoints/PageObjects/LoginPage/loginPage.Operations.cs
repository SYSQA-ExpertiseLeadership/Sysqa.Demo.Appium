using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.PageObjects
{

    public partial class LoginPage : BasePage
    {
        public MijnAccountPage LoginFromMyAccount()
        {
            var newPage = new MijnAccountPage();

            return newPage;
        }
        public MyOffersPage LoginFromMyOffers()
        {
            userNameField.SendKeys(Settings.UserInstance.UserName);
            Driver.Instance.Navigate().Back();
            passwordField.SendKeys(Settings.UserInstance.PassWord);
            Driver.Instance.Navigate().Back();
            logInButton.Click();

            var newPage = new MyOffersPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }

    }
}
