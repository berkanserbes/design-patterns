import { OrderItem } from './OrderItem';

export class Box extends OrderItem {
  private readonly items: OrderItem[] = [];

  constructor(name: string, private readonly boxWeight: number = 100) { super(name); }

  getWeight(): number {
    return this.boxWeight + this.items.reduce((sum, i) => sum + i.getWeight(), 0);
  }

  addItem(item: OrderItem): void { this.items.push(item); }
  removeItem(item: OrderItem): void {
    const idx = this.items.indexOf(item);
    if (idx !== -1) this.items.splice(idx, 1);
  }
}
