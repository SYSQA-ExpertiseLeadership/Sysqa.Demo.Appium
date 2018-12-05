using AppiumDemo.src.PageObject.Tasks;

namespace AppiumDemo.src.PageObject.System
{
    public partial class AppUnderTest
    {

        public Calendar NavigateToCalendar()
        {
            CalendarButton.Click();
            return new Calendar();

        }
        public TasksPage NavigateToTasksPage()
        {
            TasksButton.Click();
            return new TasksPage();
        }
    }
}
