namespace IteratorDesignPattern.Example2;

public class StatusFilterIterator : IIterator<Order>
{
    private readonly OrderCollection _collection;
    private readonly OrderStatus _filterStatus;
    private int _currentIndex = 0;

    public StatusFilterIterator(OrderCollection collection, OrderStatus filterStatus)
    {
        _collection = collection;
        _filterStatus = filterStatus;
    }

    public bool HasNext()
    {
        while (_currentIndex < _collection.Count)
        {
            if (_collection[_currentIndex].Status == _filterStatus)
            {
                return true;
            }
            _currentIndex++;
        }
        return false;
    }

    public Order Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more orders matching the status filter.");
        }

        return _collection[_currentIndex++];
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
