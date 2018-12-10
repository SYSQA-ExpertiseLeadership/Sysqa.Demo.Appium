using OpenQA.Selenium;
using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class HomePage :BasePage
    {
        public MeerPage NavigateToMeer()
        {
            SkipQuestion();
            meerPageButton.Click();
            TestLogger.AddToLog("Ga naar de 'MEER' pagina");
            var newPage = new MeerPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
        public KaartPage NavigateToKaart()
        {
            SkipQuestion();
            var newPage = new KaartPage();
            TestLogger.AddToLog("Navigeer naar de 'Kaart' Pagina");
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
        public AanbodPage NavigateToAanbod()
        {
            SkipQuestion();
            AanbodButton.Click();
            TestLogger.AddToLog("Navigeer naar de 'Aanbod' Pagina");
            var newPage = new AanbodPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }

        private void SkipQuestion()
        {
            if (ElementExists(By.Id("nl.airmiles.app:id/has_card")))
            {
                Driver.Instance.Navigate().Back();
                TestLogger.AddToLog("Sla de registreer pagina over");
                Wait.Until(_ => !ElementExists(By.Id("nl.airmiles.app:id/has_card")));

            }
        }
    }
}
