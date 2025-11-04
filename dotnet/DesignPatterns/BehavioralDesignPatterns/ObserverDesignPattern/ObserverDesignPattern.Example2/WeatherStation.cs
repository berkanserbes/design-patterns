namespace ObserverDesignPattern.Example2;

public class WeatherStation : ISubject
{

    private List<IObserver> observers;

    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
        Console.WriteLine($"New observer added. Total: {observers.Count}");
    }


    public void RemoveObserver(IObserver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
            Console.WriteLine($"Observer removed. Total: {observers.Count}");
        }
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;

        MeasurementsChanged();
    }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    // Getters for the measurements (optional) 
    public float GetTemperature() => temperature;
    public float GetHumidity() => humidity;
    public float GetPressure() => pressure;
}