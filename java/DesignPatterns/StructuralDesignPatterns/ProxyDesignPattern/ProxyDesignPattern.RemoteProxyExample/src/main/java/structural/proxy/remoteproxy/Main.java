package structural.proxy.remoteproxy;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== REMOTE PROXY PATTERN DEMO ===\n");

        IPaymentService paymentService = new PaymentServiceProxy("https://payment-api.example.com");
        System.out.println();

        System.out.println("--- Processing Payment ---\n");
        PaymentResult result = paymentService.processPayment(150.00, "4532015112830366");
        System.out.println();
        System.out.println("Payment Success: " + result.isSuccess());
        System.out.println("Transaction ID: " + result.getTransactionId());
        System.out.println("Message: " + result.getMessage());

        System.out.println("\n--- Checking Account Balance ---\n");
        double balance = paymentService.getBalance("ACC-001");
        System.out.println();
        System.out.println("Account Balance: " + balance);

        System.out.println("\n=== SUMMARY ===");
        System.out.println("Client called methods on proxy as if it were local.");
        System.out.println("Proxy handled all remote communication transparently.");
    }
}
