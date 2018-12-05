using AppiumDemo.src.Utillity;
using OpenQA.Selenium;

namespace AppiumDemo.src.PageObject
{
    public partial class Calendar
    {
        IWebElement elemet { get { return Driver.Instance.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[2]/android.widget.ImageView")); } }
        IWebElement elemet2 { get { return Driver.Instance.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[5]/android.widget.ImageView")); } }
        IWebElement ActionButton { get { return Driver.Instance.FindElement(By.Id("org.dmfs.tasks:id/floating_action_button")); } }
    }
}
