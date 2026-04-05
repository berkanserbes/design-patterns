import { CacheItem } from "./CacheItem";
import { IWeatherService } from "./IWeatherService";
import { RealWeatherService } from "./RealWeatherService";

/**
 * Caching Proxy with TTL (Time To Live) - Cache expires after a specified duration.
 */
export class WeatherServiceProxy implements IWeatherService {
  private readonly _realService: RealWeatherService;
  private readonly _cache: Map<string, CacheItem>;
  private readonly _cacheTtlMs: number;

  constructor(cacheTtlMs?: number) {
    this._realService = new RealWeatherService();
    this._cache = new Map();
    this._cacheTtlMs = cacheTtlMs ?? 5 * 60 * 1000; // Default: 5 minutes

    console.log(`[Proxy] Cache TTL set to: ${this._cacheTtlMs / 1000} seconds`);
  }

  async getWeather(city: string): Promise<string> {
    const key = city.toLowerCase();

    // Check cache first
    const cachedItem = this._cache.get(key);
    if (cachedItem) {
      if (!cachedItem.isExpired) {
        const remainingSec = Math.round(
          (cachedItem.expiresAt.getTime() - Date.now()) / 1000
        );
        console.log(`[Proxy] Cache HIT for '${city}' (expires in ${remainingSec}s)`);
        return cachedItem.value;
      }

      // Cache expired - remove it
      console.log(`[Proxy] Cache EXPIRED for '${city}'`);
      this._cache.delete(key);
    } else {
      console.log(`[Proxy] Cache MISS for '${city}'`);
    }

    // Fetch from real service
    const result = await this._realService.getWeather(city);

    // Store in cache with TTL
    this._cache.set(key, new CacheItem(result, this._cacheTtlMs));
    console.log(`[Proxy] Data cached for '${city}' (TTL: ${this._cacheTtlMs / 1000}s)`);

    return result;
  }

  clearCache(): void {
    this._cache.clear();
    console.log("[Proxy] Cache cleared!");
  }

  get cacheSize(): number {
    return this._cache.size;
  }
}
