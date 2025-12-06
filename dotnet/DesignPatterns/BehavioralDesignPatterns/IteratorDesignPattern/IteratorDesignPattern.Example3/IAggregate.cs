namespace IteratorDesignPattern.Example3;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
