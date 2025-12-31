using MediatR;
using Microsoft.AspNetCore.Mvc;
using MediatorDesignPattern.Example2.Commands;
using MediatorDesignPattern.Example2.Models;
using MediatorDesignPattern.Example2.Queries;

namespace MediatorDesignPattern.Example2.Controllers;

/// <summary>
/// Orders Controller - Manages order operations using MediatR
/// Controller does not contain business logic directly, routes all operations through MediatR
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Retrieves all orders
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<List<Order>>> GetAllOrders()
    {
        var query = new GetAllOrdersQuery();
        var orders = await _mediator.Send(query);
        return Ok(orders);
    }

    /// <summary>
    /// Retrieves an order by ID
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> GetOrderById(Guid id)
    {
        var query = new GetOrderByIdQuery { OrderId = id };
        var order = await _mediator.Send(query);
        
        if (order == null)
            return NotFound(new { message = "Order not found" });
        
        return Ok(order);
    }

    /// <summary>
    /// Creates a new order
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<Order>> CreateOrder([FromBody] CreateOrderCommand command)
    {
        var order = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
    }

    /// <summary>
    /// Updates order status
    /// </summary>
    [HttpPatch("{id}/status")]
    public async Task<ActionResult<Order>> UpdateOrderStatus(Guid id, [FromBody] UpdateOrderStatusRequest request)
    {
        var command = new UpdateOrderStatusCommand 
        { 
            OrderId = id, 
            NewStatus = request.Status 
        };
        
        var order = await _mediator.Send(command);
        
        if (order == null)
            return NotFound(new { message = "Order not found" });
        
        return Ok(order);
    }
}

public class UpdateOrderStatusRequest
{
    public OrderStatus Status { get; set; }
}
