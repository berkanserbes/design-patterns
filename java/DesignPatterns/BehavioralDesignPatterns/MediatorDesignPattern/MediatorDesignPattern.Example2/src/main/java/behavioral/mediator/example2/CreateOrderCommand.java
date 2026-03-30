package behavioral.mediator.example2;

public class CreateOrderCommand implements IRequest<Order> {
    private final String customerName;
    private final String productName;
    private final int quantity;
    private final double price;

    public CreateOrderCommand(String customerName, String productName, int quantity, double price) {
        this.customerName = customerName;
        this.productName = productName;
        this.quantity = quantity;
        this.price = price;
    }

    public String getCustomerName() { return customerName; }
    public String getProductName() { return productName; }
    public int getQuantity() { return quantity; }
    public double getPrice() { return price; }
}
