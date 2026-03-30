package behavioral.observer.example1;

public interface IObserver<T> {
    void update(T data);
}
