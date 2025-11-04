namespace ObserverDesignPattern.Example1;

public interface ISubject<T> 
{
    void Subscribe(IObserver<T> observer);
    void Unsubscribe(IObserver<T> observer);
    void Notify(T data);
}
