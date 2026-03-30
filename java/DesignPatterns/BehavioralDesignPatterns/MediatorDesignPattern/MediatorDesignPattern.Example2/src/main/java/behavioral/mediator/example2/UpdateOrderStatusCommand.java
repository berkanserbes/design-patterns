package behavioral.mediator.example2;

import java.util.UUID;

public class UpdateOrderStatusCommand implements IRequest<Order> {
    private final UUID orderId;
    private final OrderStatus newStatus;

    public UpdateOrderStatusCommand(UUID orderId, OrderStatus newStatus) {
        this.orderId = orderId;
        this.newStatus = newStatus;
    }

    public UUID getOrderId() { return orderId; }
    public OrderStatus getNewStatus() { return newStatus; }
}
