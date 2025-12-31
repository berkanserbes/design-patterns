using MediatR;
using MediatorDesignPattern.Example2.Models;
using MediatorDesignPattern.Example2.Queries;
using MediatorDesignPattern.Example2.Repositories;

namespace MediatorDesignPattern.Example2.Handlers;

/// <summary>
/// Query handler that retrieves all orders
/// </summary>
public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<Order>>
{
    private readonly IOrderRepository _orderRepository;

    public GetAllOrdersQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = _orderRepository.GetAll();
        
        Console.WriteLine($"[HANDLER] {orders.Count} orders retrieved");
        
        return Task.FromResult(orders);
    }
}
