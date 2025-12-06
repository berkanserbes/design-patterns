namespace IteratorDesignPattern.Example2;

public class HighValueOrderIterator : IIterator<Order>
{
    private readonly OrderCollection _collection;
    private readonly decimal _minAmount;
    private int _currentIndex = 0;

    public HighValueOrderIterator(OrderCollection collection, decimal minAmount)
    {
        _collection = collection;
        _minAmount = minAmount;
    }

    public bool HasNext()
    {
        while (_currentIndex < _collection.Count)
        {
            if (_collection[_currentIndex].TotalAmount >= _minAmount)
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
            throw new InvalidOperationException("No more high value orders.");
        }

        return _collection[_currentIndex++];
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
