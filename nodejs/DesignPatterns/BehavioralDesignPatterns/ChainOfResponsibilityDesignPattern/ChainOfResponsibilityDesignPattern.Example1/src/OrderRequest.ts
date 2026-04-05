export interface IOrderHandler {
  setNext(handler: IOrderHandler): IOrderHandler;
  handle(request: OrderRequest): void;
}

export class OrderRequest {
  orderId: string;
  customerName: string;
  productName: string;
  quantity: number;
  totalAmount: number;
  discountCode?: string;
  isApproved = false;
  readonly processMessages: string[] = [];

  constructor(init: {
    orderId: string;
    customerName: string;
    productName: string;
    quantity: number;
    totalAmount: number;
    discountCode?: string;
  }) {
    this.orderId = init.orderId;
    this.customerName = init.customerName;
    this.productName = init.productName;
    this.quantity = init.quantity;
    this.totalAmount = init.totalAmount;
    this.discountCode = init.discountCode;
  }

  addMessage(message: string): void {
    this.processMessages.push(message);
  }

  displayStatus(): void {
    console.log(`\n--- Order ${this.orderId} ---`);
    console.log(`Customer: ${this.customerName}`);
    console.log(`Product: ${this.productName} (Qty: ${this.quantity})`);
    console.log(`Total: $${this.totalAmount.toFixed(2)}`);
    console.log(`Status: ${this.isApproved ? "APPROVED" : "REJECTED"}`);
    console.log("\nProcess Log:");
    for (const msg of this.processMessages) {
      console.log(`  ${msg}`);
    }
    console.log();
  }
}
