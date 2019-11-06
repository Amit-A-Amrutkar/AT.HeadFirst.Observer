using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Weather
{
    public class CurrentConditionDisplay : IDisplayElement, IObserver
    {

        private float tempreture;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current Conditions: {0} F degrees and {1} %humidity", tempreture, humidity);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.tempreture = temp;
            this.humidity = humidity;
            display();
        }
    }
}
