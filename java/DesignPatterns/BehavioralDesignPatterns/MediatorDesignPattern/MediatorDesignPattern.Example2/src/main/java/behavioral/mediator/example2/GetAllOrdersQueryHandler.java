package behavioral.mediator.example2;

import java.util.List;

public class GetAllOrdersQueryHandler implements IRequestHandler<GetAllOrdersQuery, List<Order>> {
    private final IOrderRepository repository;
    public GetAllOrdersQueryHandler(IOrderRepository repository) { this.repository = repository; }

    @Override
    public List<Order> handle(GetAllOrdersQuery query) {
        return repository.findAll();
    }
}
