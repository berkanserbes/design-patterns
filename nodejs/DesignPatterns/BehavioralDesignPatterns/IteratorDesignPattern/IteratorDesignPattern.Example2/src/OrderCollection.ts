import { IAggregate, IIterator } from "./Interfaces";
import { Order, OrderStatus } from "./Order";
import {
  DateRangeIterator,
  HighValueOrderIterator,
  OrderIterator,
  StatusFilterIterator,
} from "./Iterators";

export class OrderCollection implements IAggregate<Order> {
  private readonly _orders: Order[] = [];

  addOrder(order: Order): void {
    this._orders.push(order);
  }

  get count(): number {
    return this._orders.length;
  }

  getAt(index: number): Order {
    return this._orders[index];
  }

  createIterator(): IIterator<Order> {
    return new OrderIterator(this);
  }

  createStatusFilterIterator(status: OrderStatus): IIterator<Order> {
    return new StatusFilterIterator(this, status);
  }

  createDateRangeIterator(startDate: Date, endDate: Date): IIterator<Order> {
    return new DateRangeIterator(this, startDate, endDate);
  }

  createHighValueIterator(minAmount: number): IIterator<Order> {
    return new HighValueOrderIterator(this, minAmount);
  }
}
