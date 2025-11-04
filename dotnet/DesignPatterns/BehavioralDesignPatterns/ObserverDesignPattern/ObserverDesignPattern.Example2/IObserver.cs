namespace ObserverDesignPattern.Example2;

public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);
}
