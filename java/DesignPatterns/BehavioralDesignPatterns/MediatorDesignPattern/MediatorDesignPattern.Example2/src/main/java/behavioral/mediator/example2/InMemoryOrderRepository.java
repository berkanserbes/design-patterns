package behavioral.mediator.example2;

import java.util.*;

public class InMemoryOrderRepository implements IOrderRepository {
    private final Map<UUID, Order> store = new LinkedHashMap<>();

    @Override
    public Order save(Order order) { store.put(order.getId(), order); return order; }

    @Override
    public Optional<Order> findById(UUID id) { return Optional.ofNullable(store.get(id)); }

    @Override
    public List<Order> findAll() { return new ArrayList<>(store.values()); }

    @Override
    public Order update(Order order) { store.put(order.getId(), order); return order; }
}
