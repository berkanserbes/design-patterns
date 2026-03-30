package behavioral.mediator.example3;

public abstract class Bidder {
    protected IAuctionMediator mediator;
    protected final String name;

    public Bidder(IAuctionMediator mediator, String name) {
        this.mediator = mediator;
        this.name = name;
    }

    public String getName() { return name; }

    public abstract void placeBid(double amount);
    public abstract void receiveNotification(String message);
}
