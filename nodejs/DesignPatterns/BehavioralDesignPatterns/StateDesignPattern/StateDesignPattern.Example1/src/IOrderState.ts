import { Order } from './Order';

export interface IOrderState {
  processOrder(order: Order): void;
  shipOrder(order: Order): void;
  deliverOrder(order: Order): void;
  cancelOrder(order: Order): void;
  getStateName(): string;
}
