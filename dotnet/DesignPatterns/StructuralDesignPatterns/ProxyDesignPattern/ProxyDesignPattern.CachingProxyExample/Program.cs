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

using ProxyDesignPattern.CachingProxyExample;

Console.WriteLine("=== CACHING PROXY PATTERN DEMO (with TTL) ===\n");

// Create proxy with 10 minute TTL (default)
var weatherService = new WeatherServiceProxy();
Console.WriteLine();

// First request - cache miss
Console.WriteLine("--- Request 1: Istanbul ---\n");
var result1 = weatherService.GetWeather("Istanbul");
Console.WriteLine($"Result: {result1}\n");

// Second request - cache hit
Console.WriteLine("--- Request 2: Istanbul (should be cached) ---\n");
var result2 = weatherService.GetWeather("Istanbul");
Console.WriteLine($"Result: {result2}\n");

// Different city - cache miss
Console.WriteLine("--- Request 3: London ---\n");
var result3 = weatherService.GetWeather("London");
Console.WriteLine($"Result: {result3}\n");

Console.WriteLine("=== SUMMARY ===");
Console.WriteLine("Request 1: Cache MISS - fetched from API");
Console.WriteLine("Request 2: Cache HIT - returned cached data");
Console.WriteLine("Request 3: Cache MISS - new city, fetched from API");
