using AppiumDemo.src.PageObject.Confirm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppiumDemo.src.PageObject.Tasks
{
    public partial class TasksPage :BasePage
    {
        public TasksPage OpenAddTasks() {
            MyTasksBar.Click();
            return this;
        }

        public TasksPage AddTask(string taks)
        {
            QuickAddTaskButton.Click();
            WaitForElement(AddTaksTitleField).SendKeys(taks);
            SaveAddedTaskButton.Click();
            WaitForElement(MyTasksBar);
            return this;
        }
        public ConfirmScreen GotToFitrstTask()
        {
            var x = Taks;
            WaitForElement(Taks.First());
            Taks.First().Click();
            Thread.Sleep(100);
            return new ConfirmScreen();
        }
    }
}
