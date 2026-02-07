namespace StateDesignPattern.Example1;

/// <summary>
/// State interface - defines the contract for all order states.
/// </summary>
public interface IOrderState
{
    void ProcessOrder(Order order);
    void ShipOrder(Order order);
    void DeliverOrder(Order order);
    void CancelOrder(Order order);
    string GetStateName();
}
