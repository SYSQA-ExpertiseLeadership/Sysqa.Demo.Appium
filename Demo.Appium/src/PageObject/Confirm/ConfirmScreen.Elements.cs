using AppiumDemo.src.Utillity;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumDemo.src.PageObject.Confirm
{
    public partial class ConfirmScreen
    {
        private IWebElement TitleBar { get { return Driver.TryFindElement(By.Id("org.dmfs.tasks:id/text")); } }

    }
}
