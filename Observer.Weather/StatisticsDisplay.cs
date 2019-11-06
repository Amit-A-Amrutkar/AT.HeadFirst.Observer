using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Weather
{
    public class StatisticsDisplay : IThirdPartyDisplay
    {
        private float tempreture;
        private float pressure;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current Conditions: {0} F degrees and {1} pressure", tempreture, pressure);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.tempreture = temp;
            this.pressure = pressure;
            display();
        }
    }
}
