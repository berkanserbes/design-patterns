package structural.proxy.remoteproxy;

import java.util.HashMap;
import java.util.Map;
import java.util.UUID;

public class RemotePaymentServer {
    private final Map<String, Double> accounts = new HashMap<>();

    public RemotePaymentServer() {
        accounts.put("ACC-001", 5000.00);
        accounts.put("ACC-002", 1500.00);
        accounts.put("ACC-003", 250.00);
    }

    public String handleRequest(String requestType, Map<String, String> parameters) {
        System.out.println("[RemoteServer] Received request: " + requestType);
        try { Thread.sleep(500); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        return switch (requestType) {
            case "PROCESS_PAYMENT" -> processPaymentRequest(parameters);
            case "GET_BALANCE" -> getBalanceRequest(parameters);
            default -> "ERROR|Unknown request type";
        };
    }

    private String processPaymentRequest(Map<String, String> parameters) {
        double amount = Double.parseDouble(parameters.get("amount"));
        System.out.println("[RemoteServer] Processing payment: " + amount);
        try { Thread.sleep(1000); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        String transactionId = "TXN-" + UUID.randomUUID().toString().substring(0, 8).toUpperCase();
        System.out.println("[RemoteServer] Payment approved. Transaction: " + transactionId);
        return "SUCCESS|" + transactionId + "|Payment processed successfully";
    }

    private String getBalanceRequest(Map<String, String> parameters) {
        String accountId = parameters.get("accountId");
        if (accounts.containsKey(accountId)) {
            double balance = accounts.get(accountId);
            System.out.println("[RemoteServer] Balance for " + accountId + ": " + balance);
            return "SUCCESS|" + balance;
        }
        return "ERROR|Account not found";
    }
}
