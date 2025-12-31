namespace MediatorDesignPattern.Example3;

/// <summary>
/// Concrete Mediator - Auctioneer that coordinates all bidding activities
/// </summary>
public class Auctioneer : IAuctionMediator
{
    private readonly List<Bidder> _bidders = new();
    private readonly string _itemName;
    private decimal _currentHighestBid;
    private Bidder? _highestBidder;

    public Auctioneer(string itemName, decimal startingPrice)
    {
        _itemName = itemName;
        _currentHighestBid = startingPrice;
        Console.WriteLine($"[AUCTIONEER] Auction started for: {_itemName}");
        Console.WriteLine($"[AUCTIONEER] Starting price: ${startingPrice}");
    }

    public void RegisterBidder(Bidder bidder)
    {
        _bidders.Add(bidder);
        Console.WriteLine($"[AUCTIONEER] {bidder.Name} joined the auction.");
    }

    public void PlaceBid(Bidder bidder, decimal amount)
    {
        if (amount <= _currentHighestBid)
        {
            bidder.ReceiveNotification($"Bid rejected. Must be higher than ${_currentHighestBid}");
            return;
        }

        _currentHighestBid = amount;
        _highestBidder = bidder;

        // Notify all other bidders about the new highest bid
        foreach (var b in _bidders.Where(b => b != bidder))
        {
            b.ReceiveNotification($"New highest bid: ${amount} by {bidder.Name}");
        }

        Console.WriteLine($"[AUCTIONEER] New highest bid: ${amount} by {bidder.Name}");
    }

    public void AnnounceWinner()
    {
        Console.WriteLine("\n[AUCTIONEER] Auction ended!");
        
        if (_highestBidder == null)
        {
            Console.WriteLine("[AUCTIONEER] No bids were placed. Item not sold.");
            return;
        }

        Console.WriteLine($"[AUCTIONEER] Winner: {_highestBidder.Name}");
        Console.WriteLine($"[AUCTIONEER] Winning bid: ${_currentHighestBid}");
        Console.WriteLine($"[AUCTIONEER] Item: {_itemName}");

        // Notify all bidders about the result
        foreach (var bidder in _bidders)
        {
            var message = bidder == _highestBidder 
                ? $"Congratulations! You won {_itemName} for ${_currentHighestBid}" 
                : $"{_itemName} sold to {_highestBidder.Name} for ${_currentHighestBid}";
            bidder.ReceiveNotification(message);
        }
    }
}
