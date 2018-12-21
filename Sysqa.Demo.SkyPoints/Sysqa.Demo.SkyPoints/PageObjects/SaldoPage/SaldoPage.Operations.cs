using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class SaldoPage : BasePage
    {
        public PopUp pressDeleteButton()
        {
            deleteButton.Click();
            TestLogger.AddToLog("Druk op Delete");
            var newScreen = new PopUp();
            Wait.Until(_ => newScreen.IsLoaded);
            return newScreen;
        }
    }
}
