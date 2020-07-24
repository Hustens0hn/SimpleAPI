using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Collections.Generic;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();


        [Fact]
        public void GetReturnsIEnumerableWeatherForecast()
        {
            var returnValue = controller.Get();


            Assert.Equal("Les Jackson" , returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
