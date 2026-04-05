import { IDatabaseConnection } from "./IDatabaseConnection";

/**
 * RealSubject - Actual database connection (expensive resource).
 */
export class RealDatabaseConnection implements IDatabaseConnection {
  private readonly _connectionId: string;
  private _isClosed = false;

  constructor() {
    this._connectionId = Math.random().toString(36).substring(2, 10).toUpperCase();
    console.log(`[Connection-${this._connectionId}] Database connection opened`);
  }

  executeQuery(query: string): void {
    if (this._isClosed) {
      throw new Error("Connection is closed");
    }

    console.log(`[Connection-${this._connectionId}] Executing: ${query}`);
    // Simulate query execution (synchronous for simplicity)
    console.log(`[Connection-${this._connectionId}] Query completed`);
  }

  close(): void {
    if (!this._isClosed) {
      this._isClosed = true;
      console.log(`[Connection-${this._connectionId}] Connection closed`);
    }
  }
}
