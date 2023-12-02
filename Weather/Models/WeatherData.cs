// Models/WeatherData.cs

using System.Collections.Generic;

public class WeatherData
{
    public string? Temperature { get; set; }
    public string? Wind { get; set; }
    public string? Description { get; set; }
    public List<Forecast> Forecast { get; set; }

    public WeatherData()
    {
        Forecast = new List<Forecast>();
    }
}

public class Forecast
{
    public string? Day { get; set; }
    public string? Temperature { get; set; }
    public string? Wind { get; set; }

    public Forecast()
    {
    }
}
