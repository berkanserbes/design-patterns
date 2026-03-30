package structural.proxy.cachingproxy;

import java.util.Random;

public class RealWeatherService implements IWeatherService {
    private final Random random = new Random();

    @Override
    public String getWeather(String city) {
        System.out.println("[RealService] Fetching weather data for '" + city + "'...");
        System.out.println("[RealService] Connecting to weather API...");
        try { Thread.sleep(2000); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        String[] conditions = {"Sunny", "Cloudy", "Rainy", "Snowy", "Windy"};
        int temp = random.nextInt(45) - 10;
        String condition = conditions[random.nextInt(conditions.length)];
        String result = condition + ", " + temp + "C";
        System.out.println("[RealService] Data received: " + result);
        return result;
    }
}
