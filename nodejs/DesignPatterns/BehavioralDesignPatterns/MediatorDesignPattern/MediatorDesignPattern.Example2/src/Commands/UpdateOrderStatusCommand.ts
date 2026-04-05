import { RequestData } from 'mediatr-ts';
import { Order, OrderStatus } from '../Models/Order';

export class UpdateOrderStatusCommand extends RequestData<Order | undefined> {
  orderId: string;
  newStatus: OrderStatus;

  constructor(orderId: string, newStatus: OrderStatus) {
    super();
    this.orderId = orderId;
    this.newStatus = newStatus;
  }
}
