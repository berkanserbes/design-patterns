package behavioral.observer.example2;

public class StatisticsDisplay implements IObserver {
    private float tempSum = 0;
    private float maxTemp = Float.MIN_VALUE;
    private float minTemp = Float.MAX_VALUE;
    private int count = 0;

    public StatisticsDisplay(ISubject weatherStation) {
        weatherStation.registerObserver(this);
    }

    @Override
    public void update(float temperature, float humidity, float pressure) {
        tempSum += temperature;
        count++;
        if (temperature > maxTemp) maxTemp = temperature;
        if (temperature < minTemp) minTemp = temperature;
        display();
    }

    public void display() {
        System.out.printf("[Statistics] Avg: %.1f C, Max: %.1f C, Min: %.1f C%n", tempSum / count, maxTemp, minTemp);
    }
}
