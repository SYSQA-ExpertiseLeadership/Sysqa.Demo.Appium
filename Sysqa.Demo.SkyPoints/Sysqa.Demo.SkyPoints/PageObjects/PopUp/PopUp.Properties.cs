namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class PopUp
    {
        public bool IsLoaded { get { return title.Displayed; } }
        public string PopUpTitle { get { return title.Text; } }
    }
}
