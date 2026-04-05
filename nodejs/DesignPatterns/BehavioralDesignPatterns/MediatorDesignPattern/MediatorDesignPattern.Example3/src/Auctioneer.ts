import { IAuctionMediator } from './IAuctionMediator';
import { Bidder } from './Bidder';

export class Auctioneer implements IAuctionMediator {
  private readonly _bidders: Bidder[] = [];
  private readonly _itemName: string;
  private _currentHighestBid: number;
  private _highestBidder: Bidder | undefined;

  constructor(itemName: string, startingPrice: number) {
    this._itemName = itemName;
    this._currentHighestBid = startingPrice;
    console.log(`[AUCTIONEER] Auction started for: ${this._itemName}`);
    console.log(`[AUCTIONEER] Starting price: $${startingPrice}`);
  }

  registerBidder(bidder: Bidder): void {
    this._bidders.push(bidder);
    console.log(`[AUCTIONEER] ${bidder.name} joined the auction.`);
  }

  placeBid(bidder: Bidder, amount: number): void {
    if (amount <= this._currentHighestBid) {
      bidder.receiveNotification(`Bid rejected. Must be higher than $${this._currentHighestBid}`);
      return;
    }

    this._currentHighestBid = amount;
    this._highestBidder = bidder;

    for (const b of this._bidders.filter(b => b !== bidder)) {
      b.receiveNotification(`New highest bid: $${amount} by ${bidder.name}`);
    }

    console.log(`[AUCTIONEER] New highest bid: $${amount} by ${bidder.name}`);
  }

  announceWinner(): void {
    console.log('\n[AUCTIONEER] Auction ended!');

    if (!this._highestBidder) {
      console.log('[AUCTIONEER] No bids were placed. Item not sold.');
      return;
    }

    console.log(`[AUCTIONEER] Winner: ${this._highestBidder.name}`);
    console.log(`[AUCTIONEER] Winning bid: $${this._currentHighestBid}`);
    console.log(`[AUCTIONEER] Item: ${this._itemName}`);

    for (const bidder of this._bidders) {
      const message = bidder === this._highestBidder
        ? `Congratulations! You won ${this._itemName} for $${this._currentHighestBid}`
        : `${this._itemName} sold to ${this._highestBidder.name} for $${this._currentHighestBid}`;
      bidder.receiveNotification(message);
    }
  }
}
