package behavioral.mediator.example3;

public class AuctionParticipant extends Bidder {
    public AuctionParticipant(IAuctionMediator mediator, String name) {
        super(mediator, name);
    }

    @Override
    public void placeBid(double amount) {
        System.out.println("[" + name + "] Places bid: $" + String.format("%.2f", amount));
        mediator.placeBid(this, amount);
    }

    @Override
    public void receiveNotification(String message) {
        System.out.println("[" + name + "] Notification: " + message);
    }
}
