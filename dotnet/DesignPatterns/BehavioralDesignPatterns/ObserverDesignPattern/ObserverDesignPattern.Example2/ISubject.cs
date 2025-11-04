using System.Xml.Serialization;

namespace ObserverDesignPattern.Example2;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
