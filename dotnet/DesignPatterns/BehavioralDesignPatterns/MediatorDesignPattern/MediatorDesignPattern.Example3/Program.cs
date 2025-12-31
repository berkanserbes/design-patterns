using MediatorDesignPattern.Example3;

// Create the mediator (Auctioneer)
var auctioneer = new Auctioneer("Vintage Painting", 100);

Console.WriteLine();

// Create bidders and register them with the mediator
var alice = new AuctionParticipant(auctioneer, "Alice");
auctioneer.RegisterBidder(alice);

var bob = new AuctionParticipant(auctioneer, "Bob");
auctioneer.RegisterBidder(bob);

var charlie = new AuctionParticipant(auctioneer, "Charlie");
auctioneer.RegisterBidder(charlie);

Console.WriteLine("\n--- Bidding Phase ---\n");

// Bidders place their bids through the mediator
alice.PlaceBid(150);
Console.WriteLine();

bob.PlaceBid(200);
Console.WriteLine();

charlie.PlaceBid(180);  // This will be rejected (lower than current highest)
Console.WriteLine();

alice.PlaceBid(250);
Console.WriteLine();

bob.PlaceBid(300);
Console.WriteLine();

auctioneer.AnnounceWinner();