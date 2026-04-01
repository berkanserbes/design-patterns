import { OrderItem } from './OrderItem';

export class Product extends OrderItem {
  constructor(name: string, public readonly weight: number) { super(name); }
  getWeight(): number { return this.weight; }
}
