import 'reflect-metadata';
import { Mediator } from 'mediatr-ts';

// Import handlers so decorators register them
import './Handlers/CreateOrderCommandHandler';
import './Handlers/GetAllOrdersQueryHandler';
import './Handlers/GetOrderByIdQueryHandler';
import './Handlers/UpdateOrderStatusCommandHandler';

import { CreateOrderCommand } from './Commands/CreateOrderCommand';
import { UpdateOrderStatusCommand } from './Commands/UpdateOrderStatusCommand';
import { GetAllOrdersQuery } from './Queries/GetAllOrdersQuery';
import { GetOrderByIdQuery } from './Queries/GetOrderByIdQuery';
import { OrderStatus } from './Models/Order';

const mediator = new Mediator();

async function main() {
  console.log('╔════════════════════════════════════════════════════════════╗');
  console.log('║       MEDIATR-TS DESIGN PATTERN - CQRS ORDER EXAMPLE      ║');
  console.log('╚════════════════════════════════════════════════════════════╝\n');

  // --- Create Orders ---
  console.log('--- Creating Orders ---');
  const order1 = await mediator.send(new CreateOrderCommand('Alice Johnson', 'Laptop Pro', 2, 1200));
  const order2 = await mediator.send(new CreateOrderCommand('Bob Smith', 'Wireless Mouse', 5, 35));
  const order3 = await mediator.send(new CreateOrderCommand('Charlie Brown', 'USB-C Hub', 3, 55));
  console.log();

  // --- Get All Orders ---
  console.log('--- Get All Orders ---');
  const allOrders = await mediator.send(new GetAllOrdersQuery());
  for (const order of allOrders) {
    console.log(`  [${order.id}] ${order.customerName} - ${order.productName} x${order.quantity} = $${order.totalAmount.toFixed(2)} | Status: ${order.status}`);
  }
  console.log();

  // --- Get Order By ID ---
  console.log('--- Get Order By ID ---');
  const found = await mediator.send(new GetOrderByIdQuery(order1.id));
  if (found) {
    console.log(`  Found: ${found.customerName} - ${found.productName} | Status: ${found.status}`);
  }
  console.log();

  // --- Update Order Status ---
  console.log('--- Update Order Status ---');
  await mediator.send(new UpdateOrderStatusCommand(order1.id, OrderStatus.Confirmed));
  await mediator.send(new UpdateOrderStatusCommand(order2.id, OrderStatus.Shipped));
  await mediator.send(new UpdateOrderStatusCommand(order3.id, OrderStatus.Cancelled));
  console.log();

  // --- Final State ---
  console.log('--- Final Order State ---');
  const updatedOrders = await mediator.send(new GetAllOrdersQuery());
  for (const order of updatedOrders) {
    console.log(`  [${order.id}] ${order.customerName} - ${order.productName} | Status: ${order.status}`);
  }
}

main().catch(console.error);
