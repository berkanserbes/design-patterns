namespace IteratorDesignPattern.Example2;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}
