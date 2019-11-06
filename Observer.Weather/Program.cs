using System;

namespace Observer.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.setMeasurements(80,65,30.4f);
            weatherData.setMeasurements(82, 70, 29.4f);
            weatherData.setMeasurements(78, 90, 20.4f);

            Console.ReadLine();
        }
    }
}
