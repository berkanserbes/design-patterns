namespace IteratorDesignPattern.Example2;

public class DateRangeIterator : IIterator<Order>
{
    private readonly OrderCollection _collection;
    private readonly DateTime _startDate;
    private readonly DateTime _endDate;
    private int _currentIndex = 0;

    public DateRangeIterator(OrderCollection collection, DateTime startDate, DateTime endDate)
    {
        _collection = collection;
        _startDate = startDate;
        _endDate = endDate;
    }

    public bool HasNext()
    {
        while (_currentIndex < _collection.Count)
        {
            var orderDate = _collection[_currentIndex].OrderDate.Date;
            if (orderDate >= _startDate.Date && orderDate <= _endDate.Date)
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
            throw new InvalidOperationException("No more orders in the date range.");
        }

        return _collection[_currentIndex++];
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
