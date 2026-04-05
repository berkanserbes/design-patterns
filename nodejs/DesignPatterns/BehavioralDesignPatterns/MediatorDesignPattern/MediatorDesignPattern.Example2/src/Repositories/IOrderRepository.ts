import { Order } from '../Models/Order';

export interface IOrderRepository {
  add(order: Order): void;
  getAll(): Order[];
  getById(id: string): Order | undefined;
  update(order: Order): void;
}
