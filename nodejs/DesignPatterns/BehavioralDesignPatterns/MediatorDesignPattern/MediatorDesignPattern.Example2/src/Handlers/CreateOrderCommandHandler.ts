import { requestHandler, RequestHandler } from 'mediatr-ts';
import { CreateOrderCommand } from '../Commands/CreateOrderCommand';
import { Order, OrderStatus } from '../Models/Order';
import { InMemoryOrderRepository } from '../Repositories/InMemoryOrderRepository';

const repository = new InMemoryOrderRepository();
export { repository as orderRepository };

@requestHandler(CreateOrderCommand)
export class CreateOrderCommandHandler implements RequestHandler<CreateOrderCommand, Order> {
  async handle(request: CreateOrderCommand): Promise<Order> {
    const order = new Order({
      id: Math.random().toString(36).substring(2, 10).toUpperCase(),
      customerName: request.customerName,
      productName: request.productName,
      quantity: request.quantity,
      price: request.price,
      status: OrderStatus.Pending,
      createdAt: new Date(),
    });

    repository.add(order);
    console.log(`[HANDLER] New order created: ${order.id}`);
    return order;
  }
}
