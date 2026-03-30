package behavioral.iterator.example3;

public interface IIterator<T> {
    boolean hasNext();
    T next();
    void reset();
}
