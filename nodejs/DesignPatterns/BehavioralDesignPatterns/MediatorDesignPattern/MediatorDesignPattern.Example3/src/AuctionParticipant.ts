import { Bidder } from './Bidder';
import { IAuctionMediator } from './IAuctionMediator';

export class AuctionParticipant extends Bidder {
  constructor(mediator: IAuctionMediator, name: string) {
    super(mediator, name);
  }

  placeBid(amount: number): void {
    console.log(`[${this.name}] Placing bid: $${amount}`);
    this.mediator.placeBid(this, amount);
  }

  receiveNotification(message: string): void {
    console.log(`[${this.name}] Notification: ${message}`);
  }
}
