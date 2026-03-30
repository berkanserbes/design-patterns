package behavioral.chainofresponsibility.example1;

import java.util.Random;

public class ShippingHandler extends BaseOrderHandler {
    private final Random random = new Random();

    @Override
    public void handle(OrderRequest request) {
        System.out.println("[ShippingHandler] Arranging shipping for order: " + request.getOrderId());
        String shippingMethod = request.getTotalAmount() > 1000 ? "Express" : "Standard";
        String trackingNumber = "TRK" + (100000 + random.nextInt(900000));
        request.addMessage("Shipping arranged: " + shippingMethod + " shipping. Tracking: " + trackingNumber);
        request.setApproved(true);
        System.out.println("  Shipping method: " + shippingMethod + ". Tracking: " + trackingNumber);
        super.handle(request);
    }
}
