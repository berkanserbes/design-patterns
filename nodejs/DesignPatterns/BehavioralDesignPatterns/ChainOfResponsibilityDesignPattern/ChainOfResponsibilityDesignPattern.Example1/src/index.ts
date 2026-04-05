// ============================================================================
// CHAIN OF RESPONSIBILITY - Example 1: Order Processing Pipeline
// ============================================================================
// Handlers: Stock → Payment → Discount → Shipping
// Each handler either processes the request and passes it down, or stops it.

import { DiscountHandler } from "./Handlers/DiscountHandler";
import { PaymentValidationHandler } from "./Handlers/PaymentValidationHandler";
import { ShippingHandler } from "./Handlers/ShippingHandler";
import { StockValidationHandler } from "./Handlers/StockValidationHandler";
import { OrderRequest } from "./OrderRequest";

// Build the chain
const stockHandler   = new StockValidationHandler();
const paymentHandler = new PaymentValidationHandler();
const discountHandler= new DiscountHandler();
const shippingHandler= new ShippingHandler();

stockHandler
  .setNext(paymentHandler)
  .setNext(discountHandler)
  .setNext(shippingHandler);

// Process an order
const order = new OrderRequest({
  orderId: "ORD-001",
  customerName: "John Doe",
  productName: "Laptop",
  quantity: 2,
  totalAmount: 3000,
  discountCode: "SUMMER20",
});

stockHandler.handle(order);
order.displayStatus();
