package behavioral.observer.example2;

public class CurrentConditionsDisplay implements IObserver {
    private float temperature;
    private float humidity;

    public CurrentConditionsDisplay(ISubject weatherStation) {
        weatherStation.registerObserver(this);
    }

    @Override
    public void update(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        display();
    }

    public void display() {
        System.out.printf("[Current Conditions] Temp: %.1f C, Humidity: %.1f%%%n", temperature, humidity);
    }
}
