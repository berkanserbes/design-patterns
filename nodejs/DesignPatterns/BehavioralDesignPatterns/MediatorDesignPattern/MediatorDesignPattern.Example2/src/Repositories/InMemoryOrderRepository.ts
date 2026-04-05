import { Order } from '../Models/Order';
import { IOrderRepository } from './IOrderRepository';

export class InMemoryOrderRepository implements IOrderRepository {
  private readonly _orders: Order[] = [];

  add(order: Order): void {
    this._orders.push(order);
  }

  getAll(): Order[] {
    return [...this._orders];
  }

  getById(id: string): Order | undefined {
    return this._orders.find(o => o.id === id);
  }

  update(order: Order): void {
    const index = this._orders.findIndex(o => o.id === order.id);
    if (index !== -1) {
      this._orders[index] = order;
    }
  }
}
