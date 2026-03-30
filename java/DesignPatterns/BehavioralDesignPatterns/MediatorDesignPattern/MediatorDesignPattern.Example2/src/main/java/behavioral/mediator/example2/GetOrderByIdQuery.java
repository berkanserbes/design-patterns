package behavioral.mediator.example2;

import java.util.UUID;

public class GetOrderByIdQuery implements IRequest<Order> {
    private final UUID orderId;
    public GetOrderByIdQuery(UUID orderId) { this.orderId = orderId; }
    public UUID getOrderId() { return orderId; }
}
