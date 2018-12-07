using OpenQA.Selenium;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class SaldoPage : BasePage
    {
        private IWebElement barCode { get { return TryFind(By.Id("nl.airmiles.app:id/barcodeImg")); } }
        private IWebElement saldo { get { return TryFind(By.Id("nl.airmiles.app:id/airmilesText")); } }
    }
}
