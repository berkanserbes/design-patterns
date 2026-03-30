package behavioral.iterator.example2;

public interface IAggregate<T> {
    IIterator<T> createIterator();
}
