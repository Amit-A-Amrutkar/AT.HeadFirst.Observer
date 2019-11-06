using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Weather
{
    public class WeatherData : ISubject
    {

        private List<IObserver> observers;
        private float tempreture;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(tempreture, humidity, pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public float getTempreture()
        {
            return this.tempreture;
        }

        public float getHumidity()
        {
            return this.humidity;
        }

        public float getPressure()
        {
            return this.pressure;
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float tempreture, float humidity, float pressure)
        {
            this.tempreture = tempreture;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
         
        }
    }
}
