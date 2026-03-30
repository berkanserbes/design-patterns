package behavioral.iterator.example2;

import java.time.LocalDate;

public class Main {
    public static void main(String[] args) {
        System.out.println("Iterator Design Pattern - Example 2: Order Management System\n");

        OrderCollection orderCollection = new OrderCollection();
        orderCollection.addOrder(new Order(1, "Alice Johnson", LocalDate.of(2024, 1, 15), 250.00, OrderStatus.Delivered));
        orderCollection.addOrder(new Order(2, "Bob Smith", LocalDate.of(2024, 1, 20), 1500.00, OrderStatus.Shipped));
        orderCollection.addOrder(new Order(3, "Charlie Brown", LocalDate.of(2024, 2, 5), 450.00, OrderStatus.Processing));
        orderCollection.addOrder(new Order(4, "Diana Prince", LocalDate.of(2024, 2, 10), 3200.00, OrderStatus.Delivered));
        orderCollection.addOrder(new Order(5, "Eve Wilson", LocalDate.of(2024, 2, 15), 180.00, OrderStatus.Pending));
        orderCollection.addOrder(new Order(6, "Frank Miller", LocalDate.of(2024, 3, 1), 2100.00, OrderStatus.Shipped));
        orderCollection.addOrder(new Order(7, "Grace Lee", LocalDate.of(2024, 3, 5), 550.00, OrderStatus.Cancelled));

        System.out.println("All Orders:");
        IIterator<Order> allOrders = orderCollection.createIterator();
        while (allOrders.hasNext()) System.out.println(allOrders.next());

        System.out.println("\nFiltered by Status (Shipped):");
        IIterator<Order> shipped = orderCollection.createStatusFilterIterator(OrderStatus.Shipped);
        while (shipped.hasNext()) System.out.println(shipped.next());

        System.out.println("\nFiltered by Date Range (February 2024):");
        IIterator<Order> dateRange = orderCollection.createDateRangeIterator(LocalDate.of(2024, 2, 1), LocalDate.of(2024, 2, 28));
        while (dateRange.hasNext()) System.out.println(dateRange.next());

        System.out.println("\nHigh Value Orders (>= $1000):");
        IIterator<Order> highValue = orderCollection.createHighValueIterator(1000.0);
        while (highValue.hasNext()) System.out.println(highValue.next());
    }
}
