using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace APITestProject
{
    [TestClass]
    public class WeatherForecastControllerTest
    {
        [TestMethod]
        public async Task GetWeatherForecastTest()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();

            var response = await httpClient.GetAsync("");
            var stringResult = await response.Content.ReadAsStringAsync();

            System.Console.WriteLine("Result of test");
            System.Console.WriteLine(stringResult);

            Assert.AreEqual(response.StatusCode, 200);
        }
    }
}