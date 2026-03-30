package behavioral.iterator.example1;

public interface IAggregate<T> {
    IIterator<T> createIterator();
}
