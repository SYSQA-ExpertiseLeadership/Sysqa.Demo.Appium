using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System.Collections.Generic;
using System.Linq;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class AanbodPage: BasePage
    {

        private IWebElement firstOffer { get { return TryFind(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.View/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.View/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.LinearLayout[1]/android.widget.LinearLayout[1]/android.widget.ImageView")); } }
        private List<AndroidElement> leftTitles { get { return TryFindAll(By.Id("nl.airmiles.app:id/titleLeft")).ToList(); } }
    }
}
