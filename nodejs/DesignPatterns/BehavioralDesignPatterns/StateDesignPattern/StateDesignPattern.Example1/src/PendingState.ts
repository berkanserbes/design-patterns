import { IOrderState } from './IOrderState';
import { Order } from './Order';
import { ProcessingState } from './ProcessingState';
import { CancelledState } from './CancelledState';

export class PendingState implements IOrderState {
  processOrder(order: Order): void {
    console.log('Order is being processed...');
    order.setState(new ProcessingState());
    console.log(`Order state changed to: ${order.getCurrentStateName()}`);
  }

  shipOrder(order: Order): void {
    console.log('Cannot ship. Order must be processed first.');
  }

  deliverOrder(order: Order): void {
    console.log('Cannot deliver. Order must be shipped first.');
  }

  cancelOrder(order: Order): void {
    console.log('Order cancelled successfully.');
    order.setState(new CancelledState());
    console.log(`Order state changed to: ${order.getCurrentStateName()}`);
  }

  getStateName(): string {
    return 'Pending';
  }
}
