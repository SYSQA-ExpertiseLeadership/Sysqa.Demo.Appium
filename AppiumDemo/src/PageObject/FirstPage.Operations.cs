using AppiumDemo.src.PageObject.AddScreenfolder;
using System.Threading;

namespace AppiumDemo.src.PageObject
{
    public partial class Calendar
    {
        public Calendar ClickAround()
        {
            for (int i = 0; i < 5; i++)
            {
                elemet.Click();
                Thread.Sleep(200);
                elemet2.Click();
                Thread.Sleep(200);
            }
            return this;
        }
        public AddScreen OpenAddScreen()
        {
            ActionButton.Click();
            return new AddScreen();

        }
    }
}
