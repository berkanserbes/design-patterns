namespace ProxyDesignPattern.CachingProxyExample;

/// <summary>
/// RealSubject - The actual weather service that makes expensive API calls.
/// Each call takes time and resources (simulated with delay).
/// </summary>
public class RealWeatherService : IWeatherService
{
    public string GetWeather(string city)
    {
        Console.WriteLine($"[RealService] Fetching weather data for '{city}'...");
        Console.WriteLine("[RealService] Connecting to weather API...");
        Thread.Sleep(2000); // Simulate slow API call

        // Simulate weather data
        var conditions = new[] { "Sunny", "Cloudy", "Rainy", "Snowy", "Windy" };
        var temp = Random.Shared.Next(-10, 35);
        var condition = conditions[Random.Shared.Next(conditions.Length)];

        var result = $"{condition}, {temp}C";
        Console.WriteLine($"[RealService] Data received: {result}");
        
        return result;
    }
}
