using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using Sysqa.Demo.SkyPoints.PageObjects;
using Sysqa.Demo.SkyPoints.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sysqa.Demo.SkyPoints.TestCases
{
    [TestFixture]
    public class TestCases
    {
        [TestCase]
        public void SaldoKaartControleren()
        {
            //ARRANGE
            
            //ACT
            var userCar = new HomePage()
                .NavigateToKaart()
                .CheckSaldo(Settings.UserInstance.CardNumber);

            //ASSERT
            userCar.balance.Should().Be("622");
        }
    }
}
