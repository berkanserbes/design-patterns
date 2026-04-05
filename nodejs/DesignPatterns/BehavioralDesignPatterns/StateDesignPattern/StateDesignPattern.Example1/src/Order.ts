import { IOrderState } from './IOrderState';
import { PendingState } from './PendingState';

export class Order {
  private _currentState: IOrderState;
  readonly orderId: string;
  readonly productName: string;

  constructor(orderId: string, productName: string) {
    this.orderId = orderId;
    this.productName = productName;
    this._currentState = new PendingState();
  }

  setState(state: IOrderState): void {
    this._currentState = state;
  }

  getCurrentStateName(): string {
    return this._currentState.getStateName();
  }

  process(): void {
    this._currentState.processOrder(this);
  }

  ship(): void {
    this._currentState.shipOrder(this);
  }

  deliver(): void {
    this._currentState.deliverOrder(this);
  }

  cancel(): void {
    this._currentState.cancelOrder(this);
  }

  printStatus(): void {
    console.log(`Order [${this.orderId}] - Product: ${this.productName} - Status: ${this.getCurrentStateName()}`);
  }
}
