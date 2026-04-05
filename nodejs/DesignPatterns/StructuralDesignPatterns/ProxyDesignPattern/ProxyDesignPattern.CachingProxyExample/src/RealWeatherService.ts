import { IWeatherService } from "./IWeatherService";

const sleep = (ms: number) => new Promise((resolve) => setTimeout(resolve, ms));

/**
 * RealSubject - The actual weather service that makes expensive API calls.
 * Each call takes time and resources (simulated with delay).
 */
export class RealWeatherService implements IWeatherService {
  async getWeather(city: string): Promise<string> {
    console.log(`[RealService] Fetching weather data for '${city}'...`);
    console.log("[RealService] Connecting to weather API...");
    await sleep(2000); // Simulate slow API call

    const conditions = ["Sunny", "Cloudy", "Rainy", "Snowy", "Windy"];
    const temp = Math.floor(Math.random() * 45) - 10; // -10 to 35
    const condition = conditions[Math.floor(Math.random() * conditions.length)];

    const result = `${condition}, ${temp}C`;
    console.log(`[RealService] Data received: ${result}`);

    return result;
  }
}
