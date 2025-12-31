namespace MediatorDesignPattern.Example2.Repositories;

using MediatorDesignPattern.Example2.Models;

/// <summary>
/// In-Memory order repository implementation
/// Used for demo purposes, real projects should use a database
/// </summary>
public class InMemoryOrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = new();

    public void Add(Order order)
    {
        _orders.Add(order);
    }

    public List<Order> GetAll()
    {
        return _orders.ToList();
    }

    public Order? GetById(Guid id)
    {
        return _orders.FirstOrDefault(o => o.Id == id);
    }

    public void Update(Order order)
    {
        var existingOrder = _orders.FirstOrDefault(o => o.Id == order.Id);
        if (existingOrder != null)
        {
            var index = _orders.IndexOf(existingOrder);
            _orders[index] = order;
        }
    }
}
