import { IAuctionMediator } from './IAuctionMediator';

export abstract class Bidder {
  protected mediator: IAuctionMediator;
  readonly name: string;

  constructor(mediator: IAuctionMediator, name: string) {
    this.mediator = mediator;
    this.name = name;
  }

  abstract placeBid(amount: number): void;
  abstract receiveNotification(message: string): void;
}
