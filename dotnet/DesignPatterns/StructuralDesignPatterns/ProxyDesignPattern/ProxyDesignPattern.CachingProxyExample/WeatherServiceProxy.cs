namespace ProxyDesignPattern.CachingProxyExample;

/// <summary>
/// Represents a cached item with expiration time.
/// </summary>
public class CacheItem
{
    public string Value { get; }
    public DateTime ExpiresAt { get; }

    public CacheItem(string value, TimeSpan ttl)
    {
        Value = value;
        ExpiresAt = DateTime.Now.Add(ttl);
    }

    public bool IsExpired => DateTime.Now > ExpiresAt;
}

/// <summary>
/// Caching Proxy with TTL (Time To Live) - Cache expires after a specified duration.
/// </summary>
public class WeatherServiceProxy : IWeatherService
{
    private readonly RealWeatherService _realService;
    private readonly Dictionary<string, CacheItem> _cache;
    private readonly TimeSpan _cacheTtl;

    public WeatherServiceProxy(TimeSpan? cacheTtl = null)
    {
        _realService = new RealWeatherService();
        _cache = new Dictionary<string, CacheItem>(StringComparer.OrdinalIgnoreCase);
        _cacheTtl = cacheTtl ?? TimeSpan.FromMinutes(5); // Default: 5 minutes
        
        Console.WriteLine($"[Proxy] Cache TTL set to: {_cacheTtl.TotalSeconds} seconds");
    }

    public string GetWeather(string city)
    {
        // Check cache first
        if (_cache.TryGetValue(city, out var cachedItem))
        {
            if (!cachedItem.IsExpired)
            {
                Console.WriteLine($"[Proxy] Cache HIT for '{city}' (expires in {(cachedItem.ExpiresAt - DateTime.Now).TotalSeconds:F0}s)");
                return cachedItem.Value;
            }
            
            // Cache expired - remove it
            Console.WriteLine($"[Proxy] Cache EXPIRED for '{city}'");
            _cache.Remove(city);
        }
        else
        {
            Console.WriteLine($"[Proxy] Cache MISS for '{city}'");
        }

        // Fetch from real service
        var result = _realService.GetWeather(city);

        // Store in cache with TTL
        _cache[city] = new CacheItem(result, _cacheTtl);
        Console.WriteLine($"[Proxy] Data cached for '{city}' (TTL: {_cacheTtl.TotalSeconds}s)");

        return result;
    }

    public void ClearCache()
    {
        _cache.Clear();
        Console.WriteLine("[Proxy] Cache cleared!");
    }

    public int CacheSize => _cache.Count;
}
