package behavioral.iterator.example3;

public interface IAggregate<T> {
    IIterator<T> createIterator();
}
