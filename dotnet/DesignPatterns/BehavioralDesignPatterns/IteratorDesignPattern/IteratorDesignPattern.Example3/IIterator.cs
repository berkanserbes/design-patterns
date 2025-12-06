namespace IteratorDesignPattern.Example3;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}
