namespace StateDesignPattern.Example1;

/// <summary>
/// Concrete State - represents an order that has been delivered.
/// </summary>
public class DeliveredState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Cannot process. Order has been delivered.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Cannot ship. Order has been delivered.");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Order has already been delivered.");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("Cannot cancel. Order has been delivered.");
    }

    public string GetStateName() => "Delivered";
}
