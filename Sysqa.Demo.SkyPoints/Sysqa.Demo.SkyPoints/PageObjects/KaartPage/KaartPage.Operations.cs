using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class KaartPage
    {
        public SaldoPage CheckSaldo(string cardNumber)
        {
            cardNumberField.SendKeys(cardNumber);
            TestLogger.AddToLog("Vul Kaart nummer in");
            cardNumberSubmit.Click();
            TestLogger.AddToLog("Klik op submit");
            var page = new SaldoPage();
            Wait.Until(_ => page.IsLoaded);
            return page;
        }

    }
}
