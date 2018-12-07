using OpenQA.Selenium.Support.UI;
using Sysqa.Demo.SkyPoints.Utilities;
using System;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class BasePage
    {
        private WebDriverWait _wait;

        public WebDriverWait Wait
        {
            get
            {
                if (_wait == null)
                {
                    _wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(15));
                }
                return _wait;
            }
        }

        public string PageTitle { get { return pageTitle.Text;} }
    }
}
