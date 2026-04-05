import { RequestData } from 'mediatr-ts';
import { Order } from '../Models/Order';

export class GetOrderByIdQuery extends RequestData<Order | undefined> {
  orderId: string;

  constructor(orderId: string) {
    super();
    this.orderId = orderId;
  }
}
