package behavioral.chainofresponsibility.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Chain of Responsibility - Order Processing ===\n");

        IOrderHandler stockHandler = new StockValidationHandler();
        IOrderHandler paymentHandler = new PaymentValidationHandler();
        IOrderHandler discountHandler = new DiscountHandler();
        IOrderHandler shippingHandler = new ShippingHandler();

        stockHandler.setNext(paymentHandler).setNext(discountHandler).setNext(shippingHandler);

        OrderRequest order = new OrderRequest("ORD-001", "John Doe", "Laptop", 2, 3000.0, "SUMMER20");

        System.out.println("Processing Order: " + order.getOrderId());
        System.out.println("Customer: " + order.getCustomerName());
        System.out.println("Product: " + order.getProductName() + " x" + order.getQuantity());
        System.out.println("Total: $" + String.format("%.2f", order.getTotalAmount()));
        System.out.println();

        stockHandler.handle(order);

        System.out.println();
        System.out.println("--- Order Processing Result ---");
        System.out.println("Approved: " + order.isApproved());
        System.out.println("Final Total: $" + String.format("%.2f", order.getTotalAmount()));
        System.out.println("Process Log:");
        for (String msg : order.getProcessMessages()) {
            System.out.println("  - " + msg);
        }
    }
}
