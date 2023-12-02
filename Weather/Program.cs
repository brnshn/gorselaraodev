using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> cityApiAddresses = new List<string>
        {
            "https://goweather.herokuapp.com/weather/istanbul",
            "https://goweather.herokuapp.com/weather/izmir",
            "https://goweather.herokuapp.com/weather/ankara"
        };

        WeatherService weatherService = new WeatherService();

        foreach (string city in cityApiAddresses)
        {
            WeatherData weatherData = weatherService.GetWeatherData(city);
            string cityName = city.Substring(city.LastIndexOf('/') + 1).ToUpper();

            Console.WriteLine($"{cityName} Weather\n");

            
            if (weatherData != null)
            {
                Console.WriteLine($"Current Weather:\n");
                // it's printing current weather
                ObjectPrinter.PrintProperties(weatherData);

                // it's printing predictions
                Console.WriteLine($"\nForecast:\n");
                foreach (Forecast forecast in weatherData.Forecast)
                {
                    ObjectPrinter.PrintProperties(forecast);
                }

                Console.WriteLine("**********************");
            }
        }

        Console.ReadKey();
    }

 
}
