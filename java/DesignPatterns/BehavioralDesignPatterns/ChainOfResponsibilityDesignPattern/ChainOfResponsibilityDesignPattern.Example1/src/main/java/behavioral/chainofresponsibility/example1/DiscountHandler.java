package behavioral.chainofresponsibility.example1;

import java.util.HashMap;
import java.util.Map;

public class DiscountHandler extends BaseOrderHandler {
    private final Map<String, Double> discountCodes = new HashMap<>();

    public DiscountHandler() {
        discountCodes.put("SUMMER20", 20.0);
        discountCodes.put("WELCOME10", 10.0);
        discountCodes.put("VIP30", 30.0);
        discountCodes.put("NEWYEAR15", 15.0);
    }

    @Override
    public void handle(OrderRequest request) {
        System.out.println("[DiscountHandler] Processing discount code: " + request.getDiscountCode());
        String code = request.getDiscountCode();
        if (code != null && !code.isEmpty() && discountCodes.containsKey(code)) {
            double rate = discountCodes.get(code);
            double discount = request.getTotalAmount() * (rate / 100.0);
            double newTotal = request.getTotalAmount() - discount;
            request.setTotalAmount(newTotal);
            request.addMessage(String.format("Discount applied: %.0f%% off (-$%.2f). New total: $%.2f", rate, discount, newTotal));
            System.out.printf("  Discount of %.0f%% applied. New total: $%.2f%n", rate, newTotal);
        } else {
            request.addMessage("No valid discount code applied.");
            System.out.println("  No discount applied.");
        }
        super.handle(request);
    }
}
