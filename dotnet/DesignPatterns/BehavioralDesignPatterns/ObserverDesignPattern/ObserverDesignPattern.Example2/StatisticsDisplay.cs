namespace ObserverDesignPattern.Example2;

public class StatisticsDisplay : IObserver
{
    private float maxTemp = float.MinValue;
    private float minTemp = float.MaxValue;
    private float tempSum = 0.0f;
    private int numReadings = 0;
    private ISubject _weatherStation;

    public StatisticsDisplay(ISubject weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        tempSum += temperature;
        numReadings++;

        if (temperature > maxTemp)
            maxTemp = temperature;

        if (temperature < minTemp)
            minTemp = temperature;

        Display();
    }

    public void Display()
    {
        float avgTemp = tempSum / numReadings;
        Console.WriteLine($"📊 Statistics - Avg: {avgTemp:F1}°C, " +
                         $"Max: {maxTemp:F1}°C, Min: {minTemp:F1}°C");
    }
}