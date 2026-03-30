package behavioral.iterator.example1;

public interface IIterator<T> {
    boolean hasNext();
    T next();
    T getCurrent();
    void reset();
}
