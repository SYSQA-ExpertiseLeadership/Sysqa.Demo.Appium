using Sysqa.Demo.SkyPoints.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysqa.Demo.SkyPoints.PageObjects
{
    public partial class HomePage
    {
        public MeerPage NavigateToMeer()
        {
            meerPageButton.Click();
            var newPage = new MeerPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
        public KaartPage NavigateToKaart()
        {
            Wait.Until(_ => OnHasACardPAge);
            Driver.Instance.Navigate().Back();
            var newPage = new KaartPage();
            Wait.Until(_ => newPage.IsLoaded);
            return newPage;
        }
    }
}
