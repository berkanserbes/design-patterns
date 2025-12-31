namespace MediatorDesignPattern.Example3;

/// <summary>
/// Concrete Colleague - Regular auction participant
/// </summary>
public class AuctionParticipant : Bidder
{
    public AuctionParticipant(IAuctionMediator mediator, string name) 
        : base(mediator, name)
    {
    }

    public override void PlaceBid(decimal amount)
    {
        Console.WriteLine($"[{Name}] Placing bid: ${amount}");
        Mediator.PlaceBid(this, amount);
    }

    public override void ReceiveNotification(string message)
    {
        Console.WriteLine($"[{Name}] Notification: {message}");
    }
}
