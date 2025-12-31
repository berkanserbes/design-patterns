namespace MediatorDesignPattern.Example2.Repositories;

using MediatorDesignPattern.Example2.Models;

/// <summary>
/// Repository interface for accessing order data
/// Handlers access data through this interface
/// </summary>
public interface IOrderRepository
{
    void Add(Order order);
    List<Order> GetAll();
    Order? GetById(Guid id);
    void Update(Order order);
}
