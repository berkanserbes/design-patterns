import { IOrderState } from './IOrderState';
import { Order } from './Order';

export class DeliveredState implements IOrderState {
  processOrder(order: Order): void {
    console.log('Cannot process. Order has been delivered.');
  }

  shipOrder(order: Order): void {
    console.log('Cannot ship. Order has been delivered.');
  }

  deliverOrder(order: Order): void {
    console.log('Order has already been delivered.');
  }

  cancelOrder(order: Order): void {
    console.log('Cannot cancel. Order has been delivered.');
  }

  getStateName(): string {
    return 'Delivered';
  }
}
