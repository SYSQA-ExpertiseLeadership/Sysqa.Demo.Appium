using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Net.Http;
using System.Text;

namespace Sysqa.Demo.SkyPoints.TestCases
{
    [TestFixture]
    public class Paypal
    {
        string bearerToken;

        string username = "";
        string pasword = "";
        [SetUp]
        public void get_credentials()
        {
            var array = Encoding.ASCII.GetBytes($"{username}:{pasword}");

            var x = new HttpClient();
            x.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            x.DefaultRequestHeaders.Add("Authorization", $"Basic {Convert.ToBase64String(array)}");
            x.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
            var body = JsonConvert.SerializeObject(new
            {
                grant_type = "client_credentials"
            });

            var stringContent = new StringContent(body.ToString());

            var result = x.PostAsync("https://api.sandbox.paypal.com/v1/oauth2/token", stringContent).Result;
            var test = result.ReasonPhrase;

        }

        [Test]
        public void Test()
        {
            var x = new HttpClient();
            x.DefaultRequestHeaders.Add("Authorization", "Bearer x");

            var body = JsonConvert.SerializeObject(new
            {

            });

            var stringContent = new StringContent(body.ToString(), Encoding.UTF8, "application/json");


            var result = x.PostAsync("https://api.sandbox.paypal.com/v1/payments/payment", stringContent).Result;

        }
    }
}
