package behavioral.mediator.example3;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Mediator Pattern - Auction System ===\n");

        Auctioneer auctioneer = new Auctioneer();

        Bidder alice = new AuctionParticipant(auctioneer, "Alice");
        Bidder bob = new AuctionParticipant(auctioneer, "Bob");
        Bidder charlie = new AuctionParticipant(auctioneer, "Charlie");

        auctioneer.registerBidder(alice);
        auctioneer.registerBidder(bob);
        auctioneer.registerBidder(charlie);

        System.out.println("\n--- Auction: Vintage Painting (starting $100) ---");
        alice.placeBid(100.0);
        bob.placeBid(150.0);
        charlie.placeBid(130.0); // rejected - lower than Bob
        alice.placeBid(200.0);
        bob.placeBid(250.0);
        charlie.placeBid(300.0);

        auctioneer.announceWinner();
    }
}
