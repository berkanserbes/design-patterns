package behavioral.chainofresponsibility.example1;

import java.util.HashMap;
import java.util.Map;

public class PaymentValidationHandler extends BaseOrderHandler {
    private final Map<String, Double> customerBalances = new HashMap<>();

    public PaymentValidationHandler() {
        customerBalances.put("John Doe", 5000.0);
        customerBalances.put("Jane Smith", 1500.0);
        customerBalances.put("Bob Johnson", 500.0);
        customerBalances.put("Alice Williams", 10000.0);
    }

    @Override
    public void handle(OrderRequest request) {
        System.out.println("[PaymentValidationHandler] Validating payment for: " + request.getCustomerName());
        double balance = customerBalances.getOrDefault(request.getCustomerName(), 0.0);
        if (balance < request.getTotalAmount()) {
            request.addMessage("Payment validation failed: Insufficient balance ($" + String.format("%.2f", balance) + ") for order total ($" + String.format("%.2f", request.getTotalAmount()) + ").");
            System.out.println("  Payment check FAILED.");
            return;
        }
        request.addMessage("Payment validation passed: Sufficient balance.");
        System.out.println("  Payment check PASSED.");
        super.handle(request);
    }
}
