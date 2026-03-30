package structural.proxy.cachingproxy;

import java.util.HashMap;
import java.util.Map;

public class WeatherServiceProxy implements IWeatherService {
    private final RealWeatherService realService;
    private final Map<String, CacheItem> cache = new HashMap<>();
    private final long cacheTtlSeconds;

    public WeatherServiceProxy(long cacheTtlSeconds) {
        this.realService = new RealWeatherService();
        this.cacheTtlSeconds = cacheTtlSeconds;
        System.out.println("[Proxy] Cache TTL set to: " + cacheTtlSeconds + " seconds");
    }

    public WeatherServiceProxy() {
        this(300);
    }

    @Override
    public String getWeather(String city) {
        String key = city.toLowerCase();
        if (cache.containsKey(key)) {
            CacheItem item = cache.get(key);
            if (!item.isExpired()) {
                System.out.println("[Proxy] Cache HIT for '" + city + "' (expires in " + item.secondsUntilExpiry() + "s)");
                return item.getValue();
            }
            System.out.println("[Proxy] Cache EXPIRED for '" + city + "'");
            cache.remove(key);
        } else {
            System.out.println("[Proxy] Cache MISS for '" + city + "'");
        }
        String result = realService.getWeather(city);
        cache.put(key, new CacheItem(result, cacheTtlSeconds));
        System.out.println("[Proxy] Data cached for '" + city + "' (TTL: " + cacheTtlSeconds + "s)");
        return result;
    }

    public void clearCache() {
        cache.clear();
        System.out.println("[Proxy] Cache cleared!");
    }

    public int getCacheSize() { return cache.size(); }
}
