/**
 * Subject Interface - Common interface for weather service and proxy.
 */
export interface IWeatherService {
  getWeather(city: string): Promise<string>;
}
