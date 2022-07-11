using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SwaggerTest.Test
{
    [TestClass]
    public class WeatherForecastControllerTests
    {
        [TestMethod]
        public async Task GetWeatherForecast()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();

            var response = await httpClient.GetAsync("");
            var stringResult = await response.Content.ReadAsStringAsync();
            
            Assert.IsNotNull(stringResult);
        }
    }
}