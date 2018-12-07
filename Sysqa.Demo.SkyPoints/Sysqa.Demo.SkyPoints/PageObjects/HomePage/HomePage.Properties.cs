namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class HomePage : BasePage
    {
        public bool OnHasACardPAge { get { return gotACardButton.Displayed; } }
    }
}
