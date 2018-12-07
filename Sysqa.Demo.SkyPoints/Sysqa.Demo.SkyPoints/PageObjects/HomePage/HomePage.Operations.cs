using OpenQA.Selenium;
using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class HomePage
    {
        public MeerPage NavigateToMeer()
        {
            SkipQuestion();
            meerPageButton.Click();
            var newPage = new MeerPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
        public KaartPage NavigateToKaart()
        {
            SkipQuestion();
            var newPage = new KaartPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
        public AanbodPage NavigateToAanbod()
        {
            SkipQuestion();
            var newPage = new AanbodPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }

        private void SkipQuestion()
        {
            if (ElementExists(By.Id("nl.airmiles.app:id/has_card")))
            {
                Driver.Instance.Navigate().Back();
                Wait.Until(_ => !ElementExists(By.Id("nl.airmiles.app:id/has_card")));

            }
        }
    }
}
