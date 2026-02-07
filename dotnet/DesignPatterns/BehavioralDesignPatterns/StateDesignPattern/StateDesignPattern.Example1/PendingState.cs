namespace StateDesignPattern.Example1;

/// <summary>
/// Concrete State - represents a pending order waiting to be processed.
/// </summary>
public class PendingState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Order is being processed...");
        order.SetState(new ProcessingState());
        Console.WriteLine($"Order state changed to: {order.GetCurrentStateName()}");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Cannot ship. Order must be processed first.");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Cannot deliver. Order must be shipped first.");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("Order cancelled successfully.");
        order.SetState(new CancelledState());
        Console.WriteLine($"Order state changed to: {order.GetCurrentStateName()}");
    }

    public string GetStateName() => "Pending";
}
