import { IOrderState } from './IOrderState';
import { Order } from './Order';
import { ShippedState } from './ShippedState';
import { CancelledState } from './CancelledState';

export class ProcessingState implements IOrderState {
  processOrder(order: Order): void {
    console.log('Order is already being processed.');
  }

  shipOrder(order: Order): void {
    console.log('Order is being shipped...');
    order.setState(new ShippedState());
    console.log(`Order state changed to: ${order.getCurrentStateName()}`);
  }

  deliverOrder(order: Order): void {
    console.log('Cannot deliver. Order must be shipped first.');
  }

  cancelOrder(order: Order): void {
    console.log('Cancelling order during processing...');
    order.setState(new CancelledState());
    console.log(`Order state changed to: ${order.getCurrentStateName()}`);
  }

  getStateName(): string {
    return 'Processing';
  }
}
