namespace IteratorDesignPattern.Example1;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    T Current { get;  }
    void Reset();
}
