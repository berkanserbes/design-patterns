package behavioral.observer.example2;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Observer Pattern - Weather Station ===\n");

        WeatherStation weatherStation = new WeatherStation();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherStation);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherStation);

        System.out.println("--- Measurement 1 ---");
        weatherStation.setMeasurements(22.0f, 65.0f, 1013.0f);

        System.out.println("\n--- Measurement 2 ---");
        weatherStation.setMeasurements(19.5f, 70.0f, 1015.0f);

        System.out.println("\n--- Measurement 3 ---");
        weatherStation.setMeasurements(25.0f, 55.0f, 1010.0f);

        System.out.println("\nRemoving currentConditionsDisplay...");
        weatherStation.removeObserver(currentDisplay);

        System.out.println("\n--- Measurement 4 (no current conditions display) ---");
        weatherStation.setMeasurements(21.0f, 60.0f, 1012.0f);
    }
}
