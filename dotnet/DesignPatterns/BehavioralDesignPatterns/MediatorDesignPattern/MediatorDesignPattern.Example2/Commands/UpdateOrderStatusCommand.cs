using MediatR;
using MediatorDesignPattern.Example2.Models;

namespace MediatorDesignPattern.Example2.Commands;

/// <summary>
/// Command to update order status
/// </summary>
public class UpdateOrderStatusCommand : IRequest<Order?>
{
    public Guid OrderId { get; set; }
    public OrderStatus NewStatus { get; set; }
}
