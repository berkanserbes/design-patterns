package behavioral.observer.example2;

import java.util.ArrayList;
import java.util.List;

public class WeatherStation implements ISubject {
    private final List<IObserver> observers = new ArrayList<>();
    private float temperature;
    private float humidity;
    private float pressure;

    @Override
    public void registerObserver(IObserver o) { observers.add(o); }

    @Override
    public void removeObserver(IObserver o) { observers.remove(o); }

    @Override
    public void notifyObservers() {
        for (IObserver o : observers) {
            o.update(temperature, humidity, pressure);
        }
    }

    public void setMeasurements(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        notifyObservers();
    }
}
