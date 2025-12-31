namespace MediatorDesignPattern.Example3;

/// <summary>
/// Mediator interface - Defines the contract for auction coordination
/// </summary>
public interface IAuctionMediator
{
    void RegisterBidder(Bidder bidder);
    void PlaceBid(Bidder bidder, decimal amount);
    void AnnounceWinner();
}
