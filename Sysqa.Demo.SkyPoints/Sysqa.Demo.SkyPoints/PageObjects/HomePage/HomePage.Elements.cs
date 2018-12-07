using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class HomePage : BasePage
    {
        private IWebElement meerPageButton { get { return TryFind(By.Id("nl.airmiles.app:id/bb_bottom_bar_icon")); } }
        private IWebElement gotACardButton { get { return TryFind(By.Id("nl.airmiles.app:id/has_card")); } }
    }
}
