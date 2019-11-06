using Observer.Weather;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Test.Observer.Weather
{
    public class TestStatisticsDisplay
    {
        WeatherData weatherData;

        StatisticsDisplay  statisticsDisplay;

        public TestStatisticsDisplay()
        {
            weatherData = new WeatherData();
            statisticsDisplay = new StatisticsDisplay(weatherData);
        }

        [Fact]
        public void UnitTestStatisticsDisplay()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                weatherData.setMeasurements(80, 65, 30.4f);

                string expected =
                    string.Format("Current Conditions: {0} F degrees and {1} pressure{2}", weatherData.getTempreture(), weatherData.getPressure(), Environment.NewLine);
                Assert.Equal(expected, sw.ToString());
            }

        }
    }
}
