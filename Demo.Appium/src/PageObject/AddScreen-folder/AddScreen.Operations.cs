using AppiumDemo.src.PageObject.Confirm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumDemo.src.PageObject.AddScreenfolder
{
    public partial class AddScreen
    {
        public ConfirmScreen MakeItem(string title)
        {
            TitleBar.SendKeys(title);
            SaveButton.Click();
            return new ConfirmScreen();
        }

    }
}
