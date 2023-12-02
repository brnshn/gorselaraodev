using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

public class WeatherService
{
    private readonly HttpClient _client;

    public WeatherService()
    {
        _client = new HttpClient();
    }

    public WeatherData GetWeatherData(string cityApiAddress)
    {
        HttpResponseMessage response = _client.GetAsync(cityApiAddress).Result;

        if (response.IsSuccessStatusCode)
        {

            string jsonData = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<WeatherData>(jsonData) ?? 
                throw new InvalidOperationException("Response content null!");

        }
        else
        {
            Console.WriteLine("Error: " + response.StatusCode);
            return new WeatherData();
        }
    }
}
