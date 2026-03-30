package behavioral.chainofresponsibility.example1;

import java.util.HashMap;
import java.util.Map;

public class StockValidationHandler extends BaseOrderHandler {
    private final Map<String, Integer> inventory = new HashMap<>();

    public StockValidationHandler() {
        inventory.put("Laptop", 10);
        inventory.put("Mouse", 50);
        inventory.put("Keyboard", 30);
        inventory.put("Monitor", 5);
        inventory.put("Headphones", 0);
    }

    @Override
    public void handle(OrderRequest request) {
        System.out.println("[StockValidationHandler] Checking stock for: " + request.getProductName());
        int available = inventory.getOrDefault(request.getProductName(), 0);
        if (available < request.getQuantity()) {
            request.addMessage("Stock validation failed: Only " + available + " units available for " + request.getProductName());
            System.out.println("  Stock check FAILED. Order cannot be processed.");
            return;
        }
        request.addMessage("Stock validation passed: " + request.getQuantity() + " units available.");
        System.out.println("  Stock check PASSED.");
        super.handle(request);
    }
}
