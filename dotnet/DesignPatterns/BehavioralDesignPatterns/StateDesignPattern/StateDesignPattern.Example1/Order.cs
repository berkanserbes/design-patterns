namespace StateDesignPattern.Example1;

/// <summary>
/// Context - maintains a reference to the current state and delegates state-specific behavior.
/// </summary>
public class Order
{
    private IOrderState _currentState;
    public string OrderId { get; }
    public string ProductName { get; }

    public Order(string orderId, string productName)
    {
        OrderId = orderId;
        ProductName = productName;
        _currentState = new PendingState();
    }

    public void SetState(IOrderState state)
    {
        _currentState = state;
    }

    public string GetCurrentStateName()
    {
        return _currentState.GetStateName();
    }

    public void Process()
    {
        _currentState.ProcessOrder(this);
    }

    public void Ship()
    {
        _currentState.ShipOrder(this);
    }

    public void Deliver()
    {
        _currentState.DeliverOrder(this);
    }

    public void Cancel()
    {
        _currentState.CancelOrder(this);
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Order [{OrderId}] - Product: {ProductName} - Status: {GetCurrentStateName()}");
    }
}
