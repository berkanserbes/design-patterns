import { IOrderState } from './IOrderState';
import { Order } from './Order';

export class CancelledState implements IOrderState {
  processOrder(order: Order): void {
    console.log('Cannot process. Order has been cancelled.');
  }

  shipOrder(order: Order): void {
    console.log('Cannot ship. Order has been cancelled.');
  }

  deliverOrder(order: Order): void {
    console.log('Cannot deliver. Order has been cancelled.');
  }

  cancelOrder(order: Order): void {
    console.log('Order has already been cancelled.');
  }

  getStateName(): string {
    return 'Cancelled';
  }
}
