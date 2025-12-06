namespace IteratorDesignPattern.Example1;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
