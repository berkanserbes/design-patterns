// ============================================================================
// ITERATOR DESIGN PATTERN - Example 2: Order Management System
// ============================================================================
// Demonstrates multiple iterator types: plain, status-filter, date-range, high-value.

import { Order, OrderStatus } from "./Order";
import { OrderCollection } from "./OrderCollection";

console.log("Iterator Design Pattern - Example 2: Order Management System\n");

const orderCollection = new OrderCollection();
orderCollection.addOrder(new Order(1, "Alice Johnson",   new Date("2024-01-15"), 250.00,  OrderStatus.Delivered));
orderCollection.addOrder(new Order(2, "Bob Smith",       new Date("2024-01-20"), 1500.00, OrderStatus.Shipped));
orderCollection.addOrder(new Order(3, "Charlie Brown",   new Date("2024-02-05"), 450.00,  OrderStatus.Processing));
orderCollection.addOrder(new Order(4, "Diana Prince",    new Date("2024-02-10"), 3200.00, OrderStatus.Delivered));
orderCollection.addOrder(new Order(5, "Eve Wilson",      new Date("2024-02-15"), 180.00,  OrderStatus.Pending));
orderCollection.addOrder(new Order(6, "Frank Miller",    new Date("2024-03-01"), 2100.00, OrderStatus.Shipped));
orderCollection.addOrder(new Order(7, "Grace Lee",       new Date("2024-03-05"), 550.00,  OrderStatus.Cancelled));

console.log("All Orders:");
const allOrdersIterator = orderCollection.createIterator();
while (allOrdersIterator.hasNext()) {
  console.log(allOrdersIterator.next().toString());
}

console.log("\nFiltered by Status (Shipped):");
const shippedIterator = orderCollection.createStatusFilterIterator(OrderStatus.Shipped);
while (shippedIterator.hasNext()) {
  console.log(shippedIterator.next().toString());
}

console.log("\nFiltered by Date Range (February 2024):");
const dateRangeIterator = orderCollection.createDateRangeIterator(
  new Date("2024-02-01"),
  new Date("2024-02-28")
);
while (dateRangeIterator.hasNext()) {
  console.log(dateRangeIterator.next().toString());
}

console.log("\nHigh Value Orders (>= $1000):");
const highValueIterator = orderCollection.createHighValueIterator(1000);
while (highValueIterator.hasNext()) {
  console.log(highValueIterator.next().toString());
}
