package behavioral.iterator.example2;

import java.time.LocalDate;

public class Order {
    private final int id;
    private final String customerName;
    private final LocalDate orderDate;
    private final double totalAmount;
    private final OrderStatus status;

    public Order(int id, String customerName, LocalDate orderDate, double totalAmount, OrderStatus status) {
        this.id = id;
        this.customerName = customerName;
        this.orderDate = orderDate;
        this.totalAmount = totalAmount;
        this.status = status;
    }

    public int getId() { return id; }
    public String getCustomerName() { return customerName; }
    public LocalDate getOrderDate() { return orderDate; }
    public double getTotalAmount() { return totalAmount; }
    public OrderStatus getStatus() { return status; }

    @Override
    public String toString() {
        return String.format("Order #%d - %s, %s, $%.2f, Status: %s", id, customerName, orderDate, totalAmount, status);
    }
}
