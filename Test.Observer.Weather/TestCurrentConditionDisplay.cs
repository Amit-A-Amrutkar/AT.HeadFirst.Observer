using Observer.Weather;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Test.Observer.Weather
{  
    
    public class TestCurrentConditionDisplay
    {
        WeatherData weatherData;

        CurrentConditionDisplay currentConditionDisplay;

        public TestCurrentConditionDisplay()
        {
            weatherData = new WeatherData();
            currentConditionDisplay = new CurrentConditionDisplay(weatherData);
        }

        [Fact]
        public void UnitTestCurrentConditionDisplay()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                weatherData.setMeasurements(80, 65, 30.4f);

                string expected =
                    string.Format("Current Conditions: {0} F degrees and {1} %humidity{2}", weatherData.getTempreture(),weatherData.getHumidity(),Environment.NewLine);
                Assert.Equal(expected, sw.ToString());
            }

        }
    }
}
