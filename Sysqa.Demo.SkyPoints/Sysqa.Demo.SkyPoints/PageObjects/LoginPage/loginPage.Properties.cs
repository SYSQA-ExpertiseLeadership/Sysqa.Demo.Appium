namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class LoginPage : BasePage
    {
       public bool IsLoaded { get { return logInButton.Displayed; } }
    }
}
