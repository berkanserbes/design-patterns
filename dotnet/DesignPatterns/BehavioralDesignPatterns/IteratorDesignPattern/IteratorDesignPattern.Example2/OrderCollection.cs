namespace IteratorDesignPattern.Example2;

public class OrderCollection : IAggregate<Order>
{
    private readonly List<Order> _orders = new();

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }

    public int Count => _orders.Count;

    public Order this[int index] => _orders[index];

    public IIterator<Order> CreateIterator()
    {
        return new OrderIterator(this);
    }

    public IIterator<Order> CreateStatusFilterIterator(OrderStatus status)
    {
        return new StatusFilterIterator(this, status);
    }

    public IIterator<Order> CreateDateRangeIterator(DateTime startDate, DateTime endDate)
    {
        return new DateRangeIterator(this, startDate, endDate);
    }

    public IIterator<Order> CreateHighValueIterator(decimal minAmount)
    {
        return new HighValueOrderIterator(this, minAmount);
    }
}
