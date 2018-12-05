using AppiumDemo.src.Utillity;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumDemo.src.PageObject.AddScreenfolder
{
    public partial class AddScreen
    {
        IWebElement TitleBar { get { return Driver.TryFindElement(By.Id("android:id/text1")); } }
        IWebElement SaveButton { get { return Driver.TryFindElement(By.Id("org.dmfs.tasks:id/editor_action_save")); } }
    }
}
