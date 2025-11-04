namespace ObserverDesignPattern.Example1;

public interface IObserver<T>
{
    void Update(T data);
}
