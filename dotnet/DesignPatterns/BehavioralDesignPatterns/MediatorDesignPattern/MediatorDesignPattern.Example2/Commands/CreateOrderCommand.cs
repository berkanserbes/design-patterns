using MediatR;
using MediatorDesignPattern.Example2.Models;

namespace MediatorDesignPattern.Example2.Commands;

/// <summary>
/// MediatR Command - Request to create a new order
/// IRequest<T> interface tells MediatR that this is a request
/// </summary>
public class CreateOrderCommand : IRequest<Order>
{
    public string CustomerName { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
