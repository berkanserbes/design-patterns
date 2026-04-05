export enum OrderStatus {
  Pending = 'Pending',
  Confirmed = 'Confirmed',
  Shipped = 'Shipped',
  Delivered = 'Delivered',
  Cancelled = 'Cancelled',
}

export class Order {
  id: string;
  customerName: string;
  productName: string;
  quantity: number;
  price: number;
  get totalAmount(): number { return this.quantity * this.price; }
  status: OrderStatus;
  createdAt: Date;
  updatedAt?: Date;

  constructor(data: Omit<Order, 'totalAmount'>) {
    this.id = data.id;
    this.customerName = data.customerName;
    this.productName = data.productName;
    this.quantity = data.quantity;
    this.price = data.price;
    this.status = data.status;
    this.createdAt = data.createdAt;
    this.updatedAt = data.updatedAt;
  }
}
