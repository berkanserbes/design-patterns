package behavioral.iterator.example2;

public interface IIterator<T> {
    boolean hasNext();
    T next();
    void reset();
}
