import { requestHandler, RequestHandler } from 'mediatr-ts';
import { UpdateOrderStatusCommand } from '../Commands/UpdateOrderStatusCommand';
import { Order } from '../Models/Order';
import { orderRepository } from './CreateOrderCommandHandler';

@requestHandler(UpdateOrderStatusCommand)
export class UpdateOrderStatusCommandHandler implements RequestHandler<UpdateOrderStatusCommand, Order | undefined> {
  async handle(request: UpdateOrderStatusCommand): Promise<Order | undefined> {
    const order = orderRepository.getById(request.orderId);

    if (!order) {
      console.log(`[HANDLER] Order not found: ${request.orderId}`);
      return undefined;
    }

    order.status = request.newStatus;
    order.updatedAt = new Date();
    orderRepository.update(order);

    console.log(`[HANDLER] Order status updated: ${order.id} -> ${order.status}`);
    return order;
  }
}
