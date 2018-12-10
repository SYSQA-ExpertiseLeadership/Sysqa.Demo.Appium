using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class PopUp
    {
        public KaartPage PressYes()
        {
            yesButton.Click();
            TestLogger.AddToLog("Druk op Ja");
            var newPage = new KaartPage();
            Wait.Until(_ => newPage.IsLoaded);

            return newPage;
        }
        public SaldoPage PressNo()
        {
            noButton.Click();
            TestLogger.AddToLog("Druk op Nee");
            var newPage = new SaldoPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
    }
}
