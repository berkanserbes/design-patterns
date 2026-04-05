import { RequestData } from 'mediatr-ts';
import { Order } from '../Models/Order';

export class GetAllOrdersQuery extends RequestData<Order[]> {
  constructor() {
    super();
  }
}
