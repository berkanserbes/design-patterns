import { IPaymentService, PaymentResult } from "./IPaymentService";
import { RemotePaymentServer } from "./RemotePaymentServer";

/**
 * Remote Proxy - Represents the remote payment service locally.
 * Handles all communication details (serialization, network, deserialization).
 * Client uses this proxy as if it were a local object.
 */
export class PaymentServiceProxy implements IPaymentService {
  private readonly _remoteServer: RemotePaymentServer;

  constructor(private readonly _serverAddress: string) {
    this._remoteServer = new RemotePaymentServer(); // Simulates connection to remote server
    console.log(`[Proxy] Connected to remote server: ${_serverAddress}`);
  }

  async processPayment(amount: number, cardNumber: string): Promise<PaymentResult> {
    console.log(`[Proxy] Preparing payment request...`);

    // Serialize request (in real scenario: JSON, XML, Protocol Buffers, etc.)
    const parameters: Record<string, string> = {
      amount: amount.toString(),
      cardNumber: this._maskCardNumber(cardNumber),
    };

    console.log(`[Proxy] Sending request to ${this._serverAddress}...`);

    // Send to remote server
    const response = await this._remoteServer.handleRequest("PROCESS_PAYMENT", parameters);

    // Deserialize response
    const parts = response.split("|");
    const success = parts[0] === "SUCCESS";
    const transactionId = success ? parts[1] : "";
    const message = success ? parts[2] : parts[1];

    console.log(`[Proxy] Response received from server`);

    return { success, transactionId, message };
  }

  async getBalance(accountId: string): Promise<number> {
    console.log(`[Proxy] Requesting balance for ${accountId}...`);

    const parameters: Record<string, string> = { accountId };

    console.log(`[Proxy] Sending request to ${this._serverAddress}...`);

    const response = await this._remoteServer.handleRequest("GET_BALANCE", parameters);

    const parts = response.split("|");
    if (parts[0] === "SUCCESS") {
      console.log(`[Proxy] Response received from server`);
      return parseFloat(parts[1]);
    }

    throw new Error(parts[1]);
  }

  private _maskCardNumber(cardNumber: string): string {
    if (cardNumber.length < 4) return "****";
    return `****-****-****-${cardNumber.slice(-4)}`;
  }
}
