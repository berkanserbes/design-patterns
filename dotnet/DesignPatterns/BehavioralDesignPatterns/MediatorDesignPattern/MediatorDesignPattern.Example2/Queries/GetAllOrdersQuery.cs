using MediatR;
using MediatorDesignPattern.Example2.Models;

namespace MediatorDesignPattern.Example2.Queries;

/// <summary>
/// Query to retrieve all orders
/// </summary>
public class GetAllOrdersQuery : IRequest<List<Order>>
{
}
