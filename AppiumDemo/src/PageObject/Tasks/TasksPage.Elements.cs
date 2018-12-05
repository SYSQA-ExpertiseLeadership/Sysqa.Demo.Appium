using AppiumDemo.src.Utillity;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace AppiumDemo.src.PageObject.Tasks
{
    public partial class TasksPage : BasePage
    {
        private IWebElement MyTasksBar { get { return Driver.TryFindElement(By.Id("android:id/title")); } }
        private IWebElement QuickAddTaskButton { get { return Driver.TryFindElement(By.Id("org.dmfs.tasks:id/quick_add_task")); } }
        private IWebElement AddTaksTitleField { get { return Driver.TryFindElement(By.Id("android:id/input")); } }
        private IWebElement SaveAddedTaskButton { get { return Driver.TryFindElement(By.Id("android:id/button1")); } }
        private IReadOnlyCollection<IWebElement> Taks { get { return Driver.TryFindElements(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.support.v4.view.ViewPager/android.widget.LinearLayout/android.widget.ExpandableListView/android.widget.LinearLayout")); } }
    }
}
