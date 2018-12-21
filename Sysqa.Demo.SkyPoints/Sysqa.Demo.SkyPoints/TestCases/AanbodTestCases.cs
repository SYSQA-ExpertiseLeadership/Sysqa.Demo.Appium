using FluentAssertions;
using NUnit.Framework;
using Sysqa.Demo.SkyPoints.PageObjects;
using Sysqa.Demo.SkyPoints.Utilities;
using System.Net.Http;

namespace Sysqa.Demo.SkyPoints.TestCases
{
    [TestFixture]
    public class AanbodTestCases : BaseTest
    {
        [Test]
        public void My_Offers_Should_Only_Be_Accesable_After_Login()
        {
            //ACT
            var page = new HomePage()
                .NavigateToAanbod()
                .SwipeToBottom()
                .PresMyOffers();

            //Assert
            page.PageTitle.Should().Be("Inloggen");
        }

        [Test]
        public void My_Offers_Should_Be_Abundant()
        {
            //ACT
            var page = new HomePage()
                .NavigateToAanbod()
                .SwipeToBottom()
                .PresMyOffers()
                .LoginFromMyOffers();

            //Assert
            page.hasOffers.Should().BeTrue();
        }
    }
}
