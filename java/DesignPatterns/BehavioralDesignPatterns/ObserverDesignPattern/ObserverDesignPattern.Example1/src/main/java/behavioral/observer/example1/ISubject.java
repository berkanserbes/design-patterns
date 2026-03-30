package behavioral.observer.example1;

public interface ISubject<T> {
    void subscribe(IObserver<T> observer);
    void unsubscribe(IObserver<T> observer);
    void notifyObservers(T data);
}
