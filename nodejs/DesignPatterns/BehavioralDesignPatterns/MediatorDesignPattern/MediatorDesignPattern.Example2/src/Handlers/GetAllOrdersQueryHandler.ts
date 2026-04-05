import { requestHandler, RequestHandler } from 'mediatr-ts';
import { GetAllOrdersQuery } from '../Queries/GetAllOrdersQuery';
import { Order } from '../Models/Order';
import { orderRepository } from './CreateOrderCommandHandler';

@requestHandler(GetAllOrdersQuery)
export class GetAllOrdersQueryHandler implements RequestHandler<GetAllOrdersQuery, Order[]> {
  async handle(_request: GetAllOrdersQuery): Promise<Order[]> {
    const orders = orderRepository.getAll();
    console.log(`[HANDLER] ${orders.length} orders retrieved`);
    return orders;
  }
}
