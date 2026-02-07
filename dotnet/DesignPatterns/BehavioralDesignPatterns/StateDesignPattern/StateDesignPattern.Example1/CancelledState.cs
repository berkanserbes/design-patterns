namespace StateDesignPattern.Example1;

/// <summary>
/// Concrete State - represents a cancelled order.
/// </summary>
public class CancelledState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Cannot process. Order has been cancelled.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Cannot ship. Order has been cancelled.");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Cannot deliver. Order has been cancelled.");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("Order has already been cancelled.");
    }

    public string GetStateName() => "Cancelled";
}
