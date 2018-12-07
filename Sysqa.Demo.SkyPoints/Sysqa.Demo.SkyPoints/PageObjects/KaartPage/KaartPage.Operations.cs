namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class KaartPage
    {
        public SaldoPage CheckSaldo(string cardNumber)
        {
            cardNumberField.SendKeys(cardNumber);
            cardNumberSubmit.Click();

            var page = new SaldoPage();
            Wait.Until(_ => page.IsLoaded);
            return page;
        }

    }
}
