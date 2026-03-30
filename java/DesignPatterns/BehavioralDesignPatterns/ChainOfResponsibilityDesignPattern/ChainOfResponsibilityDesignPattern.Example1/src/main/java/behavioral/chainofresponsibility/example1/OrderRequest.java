package behavioral.chainofresponsibility.example1;

import java.util.ArrayList;
import java.util.List;

public class OrderRequest {
    private final String orderId;
    private final String customerName;
    private final String productName;
    private final int quantity;
    private double totalAmount;
    private final String discountCode;
    private boolean isApproved;
    private final List<String> processMessages = new ArrayList<>();

    public OrderRequest(String orderId, String customerName, String productName,
                        int quantity, double totalAmount, String discountCode) {
        this.orderId = orderId;
        this.customerName = customerName;
        this.productName = productName;
        this.quantity = quantity;
        this.totalAmount = totalAmount;
        this.discountCode = discountCode;
    }

    public String getOrderId() { return orderId; }
    public String getCustomerName() { return customerName; }
    public String getProductName() { return productName; }
    public int getQuantity() { return quantity; }
    public double getTotalAmount() { return totalAmount; }
    public void setTotalAmount(double totalAmount) { this.totalAmount = totalAmount; }
    public String getDiscountCode() { return discountCode; }
    public boolean isApproved() { return isApproved; }
    public void setApproved(boolean approved) { isApproved = approved; }
    public List<String> getProcessMessages() { return processMessages; }
    public void addMessage(String message) { processMessages.add(message); }
}
