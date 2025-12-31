using MediatR;
using MediatorDesignPattern.Example2.Models;
using MediatorDesignPattern.Example2.Queries;
using MediatorDesignPattern.Example2.Repositories;

namespace MediatorDesignPattern.Example2.Handlers;

/// <summary>
/// Query handler that retrieves an order by ID
/// </summary>
public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Order?>
{
    private readonly IOrderRepository _orderRepository;

    public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task<Order?> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var order = _orderRepository.GetById(request.OrderId);
        
        Console.WriteLine(order != null 
            ? $"[HANDLER] Order found: {order.Id}" 
            : $"[HANDLER] Order not found: {request.OrderId}");
        
        return Task.FromResult(order);
    }
}
