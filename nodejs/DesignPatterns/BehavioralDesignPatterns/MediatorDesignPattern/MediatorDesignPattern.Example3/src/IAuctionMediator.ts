import { Bidder } from './Bidder';

export interface IAuctionMediator {
  registerBidder(bidder: Bidder): void;
  placeBid(bidder: Bidder, amount: number): void;
  announceWinner(): void;
}
