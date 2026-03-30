package behavioral.mediator.example2;

public class GetOrderByIdQueryHandler implements IRequestHandler<GetOrderByIdQuery, Order> {
    private final IOrderRepository repository;
    public GetOrderByIdQueryHandler(IOrderRepository repository) { this.repository = repository; }

    @Override
    public Order handle(GetOrderByIdQuery query) {
        return repository.findById(query.getOrderId())
                .orElseThrow(() -> new IllegalArgumentException("Order not found: " + query.getOrderId()));
    }
}
