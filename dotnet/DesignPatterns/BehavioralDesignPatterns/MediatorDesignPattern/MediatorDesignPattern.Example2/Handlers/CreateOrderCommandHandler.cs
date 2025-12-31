using MediatR;
using MediatorDesignPattern.Example2.Commands;
using MediatorDesignPattern.Example2.Models;
using MediatorDesignPattern.Example2.Repositories;

namespace MediatorDesignPattern.Example2.Handlers;

/// <summary>
/// Handler for CreateOrderCommand
/// IRequestHandler interface tells MediatR that this is a handler
/// </summary>
public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
{
    private readonly IOrderRepository _orderRepository;

    public CreateOrderCommandHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),
            CustomerName = request.CustomerName,
            ProductName = request.ProductName,
            Quantity = request.Quantity,
            Price = request.Price,
            Status = OrderStatus.Pending,
            CreatedAt = DateTime.UtcNow
        };

        _orderRepository.Add(order);

        Console.WriteLine($"[HANDLER] New order created: {order.Id}");
        
        return Task.FromResult(order);
    }
}
