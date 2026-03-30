package behavioral.mediator.example2;

import java.util.List;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Mediator Pattern - CQRS with Custom Mediator ===\n");

        IOrderRepository repository = new InMemoryOrderRepository();
        SimpleMediator mediator = new SimpleMediator();

        mediator.register(CreateOrderCommand.class, new CreateOrderCommandHandler(repository));
        mediator.register(UpdateOrderStatusCommand.class, new UpdateOrderStatusCommandHandler(repository));
        mediator.register(GetAllOrdersQuery.class, new GetAllOrdersQueryHandler(repository));
        mediator.register(GetOrderByIdQuery.class, new GetOrderByIdQueryHandler(repository));

        System.out.println("--- Creating Orders ---");
        Order order1 = mediator.send(new CreateOrderCommand("Alice", "Laptop", 1, 1200.00));
        Order order2 = mediator.send(new CreateOrderCommand("Bob", "Mouse", 2, 25.00));
        Order order3 = mediator.send(new CreateOrderCommand("Charlie", "Keyboard", 1, 75.00));

        System.out.println("\n--- All Orders ---");
        List<Order> allOrders = mediator.send(new GetAllOrdersQuery());
        allOrders.forEach(System.out::println);

        System.out.println("\n--- Updating Order Status ---");
        mediator.send(new UpdateOrderStatusCommand(order1.getId(), OrderStatus.Confirmed));
        mediator.send(new UpdateOrderStatusCommand(order1.getId(), OrderStatus.Shipped));

        System.out.println("\n--- Get Order by ID ---");
        Order fetched = mediator.send(new GetOrderByIdQuery(order2.getId()));
        System.out.println("Fetched: " + fetched);

        System.out.println("\n--- Final Orders ---");
        allOrders = mediator.send(new GetAllOrdersQuery());
        allOrders.forEach(System.out::println);
    }
}
