import { RequestData } from 'mediatr-ts';
import { Order } from '../Models/Order';

export class CreateOrderCommand extends RequestData<Order> {
  customerName: string;
  productName: string;
  quantity: number;
  price: number;

  constructor(customerName: string, productName: string, quantity: number, price: number) {
    super();
    this.customerName = customerName;
    this.productName = productName;
    this.quantity = quantity;
    this.price = price;
  }
}
