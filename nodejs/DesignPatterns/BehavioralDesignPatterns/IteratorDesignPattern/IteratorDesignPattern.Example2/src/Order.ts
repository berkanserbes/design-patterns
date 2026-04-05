export enum OrderStatus {
  Pending = "Pending",
  Processing = "Processing",
  Shipped = "Shipped",
  Delivered = "Delivered",
  Cancelled = "Cancelled",
}

export class Order {
  constructor(
    public readonly id: number,
    public readonly customerName: string,
    public readonly orderDate: Date,
    public readonly totalAmount: number,
    public readonly status: OrderStatus
  ) {}

  toString(): string {
    const dateStr = this.orderDate.toISOString().slice(0, 10);
    return `Order #${this.id} - ${this.customerName}, ${dateStr}, $${this.totalAmount.toFixed(2)}, Status: ${this.status}`;
  }
}
