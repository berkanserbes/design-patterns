namespace StateDesignPattern.Example1;

/// <summary>
/// Concrete State - represents an order that has been shipped.
/// </summary>
public class ShippedState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Cannot process. Order has already been shipped.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Order has already been shipped.");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Order is being delivered...");
        order.SetState(new DeliveredState());
        Console.WriteLine($"Order state changed to: {order.GetCurrentStateName()}");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("Cannot cancel. Order has already been shipped.");
    }

    public string GetStateName() => "Shipped";
}
