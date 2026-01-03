// ============================================================================
// REMOTE PROXY DESIGN PATTERN
// ============================================================================
// Remote Proxy provides a local representative for an object in a different
// address space (remote server). It handles all communication details.
// 
// Pattern Structure:
//   - IPaymentService: Subject interface
//   - RemotePaymentServer: Remote service (simulated)
//   - PaymentServiceProxy: Proxy (handles network communication)
//
// In real scenarios, the proxy would handle:
//   - Network connection management
//   - Request serialization (JSON, XML, etc.)
//   - Response deserialization
//   - Error handling and retries
// ============================================================================

namespace ProxyDesignPattern.RemoteProxyExample;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== REMOTE PROXY PATTERN DEMO ===\n");

        // Create proxy that connects to remote payment server
        IPaymentService paymentService = new PaymentServiceProxy("https://payment-api.example.com");
        Console.WriteLine();

        // Client uses proxy as if it were a local object
        Console.WriteLine("--- Processing Payment ---\n");
        var result = paymentService.ProcessPayment(150.00m, "4532015112830366");
        
        Console.WriteLine();
        Console.WriteLine($"Payment Success: {result.Success}");
        Console.WriteLine($"Transaction ID: {result.TransactionId}");
        Console.WriteLine($"Message: {result.Message}");

        Console.WriteLine("\n--- Checking Account Balance ---\n");
        var balance = paymentService.GetBalance("ACC-001");
        
        Console.WriteLine();
        Console.WriteLine($"Account Balance: {balance:C}");

        Console.WriteLine("\n=== SUMMARY ===");
        Console.WriteLine("Client called methods on proxy as if it were local.");
        Console.WriteLine("Proxy handled all remote communication transparently.");
    }
}
