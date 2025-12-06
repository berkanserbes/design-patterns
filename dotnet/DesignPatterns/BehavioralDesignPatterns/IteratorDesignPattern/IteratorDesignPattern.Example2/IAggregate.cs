namespace IteratorDesignPattern.Example2;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
