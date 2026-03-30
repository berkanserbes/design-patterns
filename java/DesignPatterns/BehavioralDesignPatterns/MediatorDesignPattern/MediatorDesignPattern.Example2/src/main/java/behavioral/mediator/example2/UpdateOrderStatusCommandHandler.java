package behavioral.mediator.example2;

public class UpdateOrderStatusCommandHandler implements IRequestHandler<UpdateOrderStatusCommand, Order> {
    private final IOrderRepository repository;
    public UpdateOrderStatusCommandHandler(IOrderRepository repository) { this.repository = repository; }

    @Override
    public Order handle(UpdateOrderStatusCommand command) {
        Order order = repository.findById(command.getOrderId())
                .orElseThrow(() -> new IllegalArgumentException("Order not found: " + command.getOrderId()));
        order.setStatus(command.getNewStatus());
        repository.update(order);
        System.out.println("[UpdateStatusHandler] Updated: " + order);
        return order;
    }
}
