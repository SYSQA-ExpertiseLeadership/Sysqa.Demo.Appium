using Sysqa.Demo.SkyPoints.Utilities;
using System;
using System.Linq;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class AanbodPage: BasePage
    {
        public AanbodPage SwipeToTop()
        {
           // if (leftTitles.Where(x => x.Text == "Speciaal voor jou!").Count() == 0)
            //{
                Driver.Instance.Swipe(390, 100, 390, 820, 100);
            Console.WriteLine("SWIPE Omlaag");
            // }
            return this;
        }
        public AanbodPage SwipeToBottom()
        {
           // if (leftTitles.Where(x => x.Text == "uitgelicht").Count() == 0)
            //{
                Driver.Instance.Swipe(390, 820, 390, 100, 100);
            Console.WriteLine("SWIPE Omhoog");
           // }
            return this;
        }

        public LoginPage PresMyOffers()
        {
            leftTitles.Where(x => x.Text == "Speciaal voor jou!").First().Click();
            var newPage = new LoginPage();
            Wait.Until(_ => newPage.IsLoaded);

            return newPage;
        }
    }
}
