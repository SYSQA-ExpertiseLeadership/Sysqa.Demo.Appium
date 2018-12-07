namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class PopUp
    {
        public KaartPage PressYes()
        {
            yesButton.Click();
            var newPage = new KaartPage();
            Wait.Until(_ => newPage.IsLoaded);

            return newPage;
        }
        public SaldoPage PressNo()
        {
            noButton.Click();
            var newPage = new SaldoPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
    }
}
