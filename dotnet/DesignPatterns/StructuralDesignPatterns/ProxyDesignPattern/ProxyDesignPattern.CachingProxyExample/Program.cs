// ============================================================================
// CACHING PROXY DESIGN PATTERN (with TTL)
// ============================================================================
// Caching Proxy stores results of expensive operations and returns cached
// results when the same operation is requested again.
// 
// This implementation includes TTL (Time To Live) - cache expires after
// a specified duration to prevent stale data.
//
// Pattern Structure:
//   - IWeatherService: Subject interface
//   - RealWeatherService: RealSubject (expensive API calls)
//   - WeatherServiceProxy: Proxy (caches results with TTL)
// ============================================================================

namespace ProxyDesignPattern.CachingProxyExample;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== CACHING PROXY PATTERN DEMO (with TTL) ===\n");

        // Create proxy with 5 second TTL for demo purposes
        var weatherService = new WeatherServiceProxy(cacheTtl: TimeSpan.FromMinutes(10));
        Console.WriteLine();

        // First request - cache miss
        Console.WriteLine("--- Request 1: Istanbul ---\n");
        var result1 = weatherService.GetWeather("Istanbul");
        Console.WriteLine($"Result: {result1}\n");

        // Second request - cache hit
        Console.WriteLine("--- Request 2: Istanbul (should be cached) ---\n");
        var result2 = weatherService.GetWeather("Istanbul");
        Console.WriteLine($"Result: {result2}\n");

        // Third request - cache expired, will fetch again
        Console.WriteLine("--- Request 3: Istanbul (cache expired) ---\n");
        var result3 = weatherService.GetWeather("Istanbul");
        Console.WriteLine($"Result: {result3}\n");

        Console.WriteLine("=== SUMMARY ===");
        Console.WriteLine("Request 1: Cache MISS - fetched from API");
        Console.WriteLine("Request 2: Cache HIT - returned cached data");
        Console.WriteLine("Request 3: Cache EXPIRED - fetched fresh data from API");
    }
}
