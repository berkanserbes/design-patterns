namespace ProxyDesignPattern.CachingProxyExample;

/// <summary>
/// Subject Interface - Common interface for weather service and proxy.
/// </summary>
public interface IWeatherService
{
    string GetWeather(string city);
}
