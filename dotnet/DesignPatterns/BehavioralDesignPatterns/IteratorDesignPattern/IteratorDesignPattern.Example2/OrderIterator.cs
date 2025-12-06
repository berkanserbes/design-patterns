namespace IteratorDesignPattern.Example2;

public class OrderIterator : IIterator<Order>
{
    private readonly OrderCollection _collection;
    private int _currentIndex = 0;

    public OrderIterator(OrderCollection collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _currentIndex < _collection.Count;
    }

    public Order Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more orders in collection.");
        }

        return _collection[_currentIndex++];
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
