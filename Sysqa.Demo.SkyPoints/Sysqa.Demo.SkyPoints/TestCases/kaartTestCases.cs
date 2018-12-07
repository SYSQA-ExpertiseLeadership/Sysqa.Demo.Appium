using FluentAssertions;
using NUnit.Framework;
using Sysqa.Demo.SkyPoints.PageObjects;
using Sysqa.Demo.SkyPoints.Utilities;

namespace Sysqa.Demo.SkyPoints.TestCases
{
    [TestFixture]
    public class kaartTestCases
    {
        [Test]
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
        [TestCase]
        public void DeleteMoetPopupTonen()
        {
            //ARRANGE

            //ACT
            var userCar = new HomePage()
                .NavigateToKaart()
                .CheckSaldo(Settings.UserInstance.CardNumber)
                .pressDeleteButton();

            //ASSERT
            userCar.PopUpTitle.Should().Be("Air Miles kaart verwijderen");

            //ACT
            var x = userCar.PressYes();

            //ASSERT
            x.IsLoaded.Should().BeTrue();

        }
        
    }
}
