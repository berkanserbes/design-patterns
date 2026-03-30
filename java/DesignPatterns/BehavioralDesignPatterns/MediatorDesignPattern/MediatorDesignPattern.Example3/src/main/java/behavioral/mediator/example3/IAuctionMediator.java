package behavioral.mediator.example3;

public interface IAuctionMediator {
    void registerBidder(Bidder bidder);
    void placeBid(Bidder bidder, double amount);
    void announceWinner();
}
