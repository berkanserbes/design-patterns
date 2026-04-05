import { requestHandler, RequestHandler } from 'mediatr-ts';
import { GetOrderByIdQuery } from '../Queries/GetOrderByIdQuery';
import { Order } from '../Models/Order';
import { orderRepository } from './CreateOrderCommandHandler';

@requestHandler(GetOrderByIdQuery)
export class GetOrderByIdQueryHandler implements RequestHandler<GetOrderByIdQuery, Order | undefined> {
  async handle(request: GetOrderByIdQuery): Promise<Order | undefined> {
    const order = orderRepository.getById(request.orderId);
    console.log(order
      ? `[HANDLER] Order found: ${order.id}`
      : `[HANDLER] Order not found: ${request.orderId}`);
    return order;
  }
}
