package behavioral.mediator.example2;

import java.time.LocalDateTime;
import java.util.UUID;

public class Order {
    private final UUID id;
    private final String customerName;
    private final String productName;
    private final int quantity;
    private final double price;
    private OrderStatus status;
    private final LocalDateTime createdAt;

    public Order(UUID id, String customerName, String productName, int quantity, double price) {
        this.id = id;
        this.customerName = customerName;
        this.productName = productName;
        this.quantity = quantity;
        this.price = price;
        this.status = OrderStatus.Pending;
        this.createdAt = LocalDateTime.now();
    }

    public UUID getId() { return id; }
    public String getCustomerName() { return customerName; }
    public String getProductName() { return productName; }
    public int getQuantity() { return quantity; }
    public double getPrice() { return price; }
    public OrderStatus getStatus() { return status; }
    public void setStatus(OrderStatus status) { this.status = status; }
    public LocalDateTime getCreatedAt() { return createdAt; }

    @Override
    public String toString() {
        return String.format("Order[%s] %s - %s x%d @ $%.2f [%s]",
                id.toString().substring(0, 8), customerName, productName, quantity, price, status);
    }
}
