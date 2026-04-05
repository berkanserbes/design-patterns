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

import { IWeatherService } from "./IWeatherService";
import { WeatherServiceProxy } from "./WeatherServiceProxy";

async function main() {
  console.log("=== CACHING PROXY PATTERN DEMO (with TTL) ===\n");

  // Create proxy with 5 minute TTL (default)
  const weatherService: IWeatherService = new WeatherServiceProxy();
  console.log();

  // First request - cache miss
  console.log("--- Request 1: Istanbul ---\n");
  const result1 = await weatherService.getWeather("Istanbul");
  console.log(`Result: ${result1}\n`);

  // Second request - cache hit
  console.log("--- Request 2: Istanbul (should be cached) ---\n");
  const result2 = await weatherService.getWeather("Istanbul");
  console.log(`Result: ${result2}\n`);

  // Different city - cache miss
  console.log("--- Request 3: London ---\n");
  const result3 = await weatherService.getWeather("London");
  console.log(`Result: ${result3}\n`);

  console.log("=== SUMMARY ===");
  console.log("Request 1: Cache MISS - fetched from API");
  console.log("Request 2: Cache HIT - returned cached data");
  console.log("Request 3: Cache MISS - new city, fetched from API");
}

main();
