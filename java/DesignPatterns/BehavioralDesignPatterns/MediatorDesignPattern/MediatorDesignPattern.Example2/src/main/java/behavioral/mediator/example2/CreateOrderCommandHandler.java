package behavioral.mediator.example2;

import java.util.UUID;

public class CreateOrderCommandHandler implements IRequestHandler<CreateOrderCommand, Order> {
    private final IOrderRepository repository;
    public CreateOrderCommandHandler(IOrderRepository repository) { this.repository = repository; }

    @Override
    public Order handle(CreateOrderCommand command) {
        Order order = new Order(UUID.randomUUID(), command.getCustomerName(),
                command.getProductName(), command.getQuantity(), command.getPrice());
        repository.save(order);
        System.out.println("[CreateOrderHandler] Created: " + order);
        return order;
    }
}
