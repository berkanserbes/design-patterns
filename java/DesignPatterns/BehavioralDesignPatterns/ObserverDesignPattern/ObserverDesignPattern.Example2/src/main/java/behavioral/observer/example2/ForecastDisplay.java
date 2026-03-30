package behavioral.observer.example2;

public class ForecastDisplay implements IObserver {
    private float lastPressure = 1013.25f;
    private float currentPressure;

    public ForecastDisplay(ISubject weatherStation) {
        weatherStation.registerObserver(this);
    }

    @Override
    public void update(float temperature, float humidity, float pressure) {
        lastPressure = currentPressure == 0 ? pressure : currentPressure;
        currentPressure = pressure;
        display();
    }

    public void display() {
        String forecast;
        if (currentPressure > lastPressure) forecast = "Improving weather on the way!";
        else if (currentPressure == lastPressure) forecast = "More of the same";
        else forecast = "Watch out for cooler, rainy weather";
        System.out.println("[Forecast] " + forecast);
    }
}
