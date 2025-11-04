namespace ObserverDesignPattern.Example2;

public class CurrentConditionsDisplay : IObserver
{
    private float temperature;
    private float humidity;
    private ISubject _weatherStation;

    public CurrentConditionsDisplay(ISubject weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"🌡️  Current Conditions: {temperature}°C, Humidity: {humidity}%");
    }
}