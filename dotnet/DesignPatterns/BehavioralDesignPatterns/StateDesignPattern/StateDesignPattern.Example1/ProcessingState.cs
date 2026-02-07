namespace StateDesignPattern.Example1;

/// <summary>
/// Concrete State - represents an order being processed.
/// </summary>
public class ProcessingState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Order is already being processed.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Order is being shipped...");
        order.SetState(new ShippedState());
        Console.WriteLine($"Order state changed to: {order.GetCurrentStateName()}");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Cannot deliver. Order must be shipped first.");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("Cancelling order during processing...");
        order.SetState(new CancelledState());
        Console.WriteLine($"Order state changed to: {order.GetCurrentStateName()}");
    }

    public string GetStateName() => "Processing";
}
