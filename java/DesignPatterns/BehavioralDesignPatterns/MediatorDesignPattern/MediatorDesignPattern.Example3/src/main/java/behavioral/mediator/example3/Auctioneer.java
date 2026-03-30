package behavioral.mediator.example3;

import java.util.*;

public class Auctioneer implements IAuctionMediator {
    private final List<Bidder> bidders = new ArrayList<>();
    private double highestBid = 0;
    private Bidder highestBidder = null;

    @Override
    public void registerBidder(Bidder bidder) {
        bidders.add(bidder);
        System.out.println("[Auctioneer] Registered bidder: " + bidder.getName());
    }

    @Override
    public void placeBid(Bidder bidder, double amount) {
        if (amount > highestBid) {
            highestBid = amount;
            highestBidder = bidder;
            String notification = bidder.getName() + " is now the highest bidder at $" + String.format("%.2f", amount);
            for (Bidder b : bidders) {
                b.receiveNotification(notification);
            }
        } else {
            bidder.receiveNotification("Bid of $" + String.format("%.2f", amount) + " rejected. Current highest: $" + String.format("%.2f", highestBid));
        }
    }

    @Override
    public void announceWinner() {
        System.out.println("\n[Auctioneer] SOLD! Winner: " + (highestBidder != null ? highestBidder.getName() : "none") + " at $" + String.format("%.2f", highestBid));
    }
}
