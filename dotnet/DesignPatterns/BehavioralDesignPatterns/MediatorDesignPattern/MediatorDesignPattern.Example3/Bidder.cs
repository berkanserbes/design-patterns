namespace MediatorDesignPattern.Example3;

/// <summary>
/// Colleague abstract class - Base class for all bidders
/// </summary>
public abstract class Bidder
{
    protected IAuctionMediator Mediator;
    public string Name { get; }

    protected Bidder(IAuctionMediator mediator, string name)
    {
        Mediator = mediator;
        Name = name;
    }

    public abstract void PlaceBid(decimal amount);
    public abstract void ReceiveNotification(string message);
}
