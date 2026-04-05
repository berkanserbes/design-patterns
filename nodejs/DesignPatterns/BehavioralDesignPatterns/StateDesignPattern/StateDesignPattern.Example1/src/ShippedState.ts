import { IOrderState } from './IOrderState';
import { Order } from './Order';
import { DeliveredState } from './DeliveredState';

export class ShippedState implements IOrderState {
  processOrder(order: Order): void {
    console.log('Cannot process. Order has already been shipped.');
  }

  shipOrder(order: Order): void {
    console.log('Order has already been shipped.');
  }

  deliverOrder(order: Order): void {
    console.log('Order is being delivered...');
    order.setState(new DeliveredState());
    console.log(`Order state changed to: ${order.getCurrentStateName()}`);
  }

  cancelOrder(order: Order): void {
    console.log('Cannot cancel. Order has already been shipped.');
  }

  getStateName(): string {
    return 'Shipped';
  }
}
