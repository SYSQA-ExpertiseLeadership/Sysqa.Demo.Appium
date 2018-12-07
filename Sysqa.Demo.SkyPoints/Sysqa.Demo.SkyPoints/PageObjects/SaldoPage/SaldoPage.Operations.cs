namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class SaldoPage : BasePage
    {
        public PopUp pressDeleteButton()
        {
            deleteButton.Click();
            var newScreen = new PopUp();
            Wait.Until(_ => newScreen.IsLoaded);
            return newScreen;
        }
    }
}
