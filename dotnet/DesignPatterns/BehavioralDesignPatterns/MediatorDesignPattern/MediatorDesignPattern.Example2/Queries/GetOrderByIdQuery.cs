using MediatR;
using MediatorDesignPattern.Example2.Models;

namespace MediatorDesignPattern.Example2.Queries;

/// <summary>
/// MediatR Query - Query order by ID
/// </summary>
public class GetOrderByIdQuery : IRequest<Order?>
{
    public Guid OrderId { get; set; }
}
