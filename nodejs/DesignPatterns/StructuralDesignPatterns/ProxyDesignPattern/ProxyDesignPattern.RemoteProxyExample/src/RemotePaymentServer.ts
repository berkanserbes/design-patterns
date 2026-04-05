const sleep = (ms: number) => new Promise((resolve) => setTimeout(resolve, ms));

/**
 * Simulates a remote payment server running on a different machine.
 * In real scenarios, this would be an actual remote service.
 */
export class RemotePaymentServer {
  private readonly _accounts: Map<string, number> = new Map([
    ["ACC-001", 5000.0],
    ["ACC-002", 1500.0],
    ["ACC-003", 250.0],
  ]);

  async handleRequest(
    requestType: string,
    parameters: Record<string, string>
  ): Promise<string> {
    console.log(`[RemoteServer] Received request: ${requestType}`);
    await sleep(500); // Simulate network latency

    switch (requestType) {
      case "PROCESS_PAYMENT":
        return this._processPaymentRequest(parameters);
      case "GET_BALANCE":
        return this._getBalanceRequest(parameters);
      default:
        return "ERROR|Unknown request type";
    }
  }

  private async _processPaymentRequest(
    parameters: Record<string, string>
  ): Promise<string> {
    const amount = parseFloat(parameters["amount"]);
    console.log(`[RemoteServer] Processing payment: $${amount.toFixed(2)}`);
    await sleep(1000); // Simulate processing time

    const transactionId = `TXN-${Math.random().toString(36).substring(2, 10).toUpperCase()}`;
    console.log(`[RemoteServer] Payment approved. Transaction: ${transactionId}`);
    return `SUCCESS|${transactionId}|Payment processed successfully`;
  }

  private _getBalanceRequest(parameters: Record<string, string>): string {
    const accountId = parameters["accountId"];
    const balance = this._accounts.get(accountId);

    if (balance !== undefined) {
      console.log(`[RemoteServer] Balance for ${accountId}: $${balance.toFixed(2)}`);
      return `SUCCESS|${balance}`;
    }

    return "ERROR|Account not found";
  }
}
