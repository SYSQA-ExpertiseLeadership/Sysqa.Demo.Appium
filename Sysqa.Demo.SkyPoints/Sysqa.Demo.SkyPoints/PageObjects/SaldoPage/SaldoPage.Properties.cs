namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class SaldoPage : BasePage
    {
        public bool IsLoaded { get { return barCode.Displayed; } }
        public string balance { get { return saldo.Text; } }
    }
}
