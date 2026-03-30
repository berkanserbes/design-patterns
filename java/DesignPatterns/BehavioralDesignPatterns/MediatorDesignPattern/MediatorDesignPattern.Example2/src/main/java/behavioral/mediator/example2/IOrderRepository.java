package behavioral.mediator.example2;

import java.util.*;

public interface IOrderRepository {
    Order save(Order order);
    Optional<Order> findById(UUID id);
    List<Order> findAll();
    Order update(Order order);
}
