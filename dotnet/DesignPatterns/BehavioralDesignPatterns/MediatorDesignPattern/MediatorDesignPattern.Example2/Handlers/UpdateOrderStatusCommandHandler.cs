using MediatR;
using MediatorDesignPattern.Example2.Commands;
using MediatorDesignPattern.Example2.Models;
using MediatorDesignPattern.Example2.Repositories;

namespace MediatorDesignPattern.Example2.Handlers;

/// <summary>
/// Handler for updating order status
/// </summary>
public class UpdateOrderStatusCommandHandler : IRequestHandler<UpdateOrderStatusCommand, Order?>
{
    private readonly IOrderRepository _orderRepository;

    public UpdateOrderStatusCommandHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task<Order?> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
    {
        var order = _orderRepository.GetById(request.OrderId);
        
        if (order == null)
        {
            Console.WriteLine($"[HANDLER] Order not found: {request.OrderId}");
            return Task.FromResult<Order?>(null);
        }

        order.Status = request.NewStatus;
        order.UpdatedAt = DateTime.UtcNow;
        
        _orderRepository.Update(order);

        Console.WriteLine($"[HANDLER] Order status updated: {order.Id} -> {order.Status}");
        
        return Task.FromResult<Order?>(order);
    }
}
