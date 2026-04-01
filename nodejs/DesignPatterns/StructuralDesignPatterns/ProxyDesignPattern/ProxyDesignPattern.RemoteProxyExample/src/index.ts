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

import { IPaymentService } from "./IPaymentService";
import { PaymentServiceProxy } from "./PaymentServiceProxy";

async function main() {
  console.log("=== REMOTE PROXY PATTERN DEMO ===\n");

  // Create proxy that connects to remote payment server
  const paymentService: IPaymentService = new PaymentServiceProxy(
    "https://payment-api.example.com"
  );
  console.log();

  // Client uses proxy as if it were a local object
  console.log("--- Processing Payment ---\n");
  const result = await paymentService.processPayment(150.0, "4532015112830366");

  console.log();
  console.log(`Payment Success: ${result.success}`);
  console.log(`Transaction ID: ${result.transactionId}`);
  console.log(`Message: ${result.message}`);

  console.log("\n--- Checking Account Balance ---\n");
  const balance = await paymentService.getBalance("ACC-001");

  console.log();
  console.log(`Account Balance: $${balance.toFixed(2)}`);

  console.log("\n=== SUMMARY ===");
  console.log("Client called methods on proxy as if it were local.");
  console.log("Proxy handled all remote communication transparently.");
}

main();
