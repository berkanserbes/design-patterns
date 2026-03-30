package structural.proxy.remoteproxy;

import java.util.HashMap;
import java.util.Map;

public class PaymentServiceProxy implements IPaymentService {
    private final RemotePaymentServer remoteServer;
    private final String serverAddress;

    public PaymentServiceProxy(String serverAddress) {
        this.serverAddress = serverAddress;
        this.remoteServer = new RemotePaymentServer();
        System.out.println("[Proxy] Connected to remote server: " + serverAddress);
    }

    @Override
    public PaymentResult processPayment(double amount, String cardNumber) {
        System.out.println("[Proxy] Preparing payment request...");
        Map<String, String> parameters = new HashMap<>();
        parameters.put("amount", String.valueOf(amount));
        parameters.put("cardNumber", maskCardNumber(cardNumber));
        System.out.println("[Proxy] Sending request to " + serverAddress + "...");
        String response = remoteServer.handleRequest("PROCESS_PAYMENT", parameters);
        String[] parts = response.split("\\|");
        boolean success = "SUCCESS".equals(parts[0]);
        String transactionId = success ? parts[1] : "";
        String message = success ? parts[2] : parts[1];
        System.out.println("[Proxy] Response received from server");
        return new PaymentResult(success, transactionId, message);
    }

    @Override
    public double getBalance(String accountId) {
        System.out.println("[Proxy] Requesting balance for " + accountId + "...");
        Map<String, String> parameters = new HashMap<>();
        parameters.put("accountId", accountId);
        System.out.println("[Proxy] Sending request to " + serverAddress + "...");
        String response = remoteServer.handleRequest("GET_BALANCE", parameters);
        String[] parts = response.split("\\|");
        if ("SUCCESS".equals(parts[0])) {
            System.out.println("[Proxy] Response received from server");
            return Double.parseDouble(parts[1]);
        }
        throw new RuntimeException(parts[1]);
    }

    private static String maskCardNumber(String cardNumber) {
        if (cardNumber.length() < 4) return "****";
        return "****-****-****-" + cardNumber.substring(cardNumber.length() - 4);
    }
}
