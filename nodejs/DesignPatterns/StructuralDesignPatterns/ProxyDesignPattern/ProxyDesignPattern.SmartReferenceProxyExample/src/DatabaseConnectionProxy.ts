import { IDatabaseConnection } from "./IDatabaseConnection";
import { RealDatabaseConnection } from "./RealDatabaseConnection";

/**
 * Smart Reference Proxy - Tracks references and adds extra behavior:
 * - Reference counting
 * - Access logging
 * - Last access time tracking
 * - Auto-close when reference count reaches zero
 */
export class DatabaseConnectionProxy implements IDatabaseConnection {
  private readonly _realConnection: RealDatabaseConnection;
  private readonly _proxyId: string;

  private _referenceCount: number;
  private _queryCount: number;
  private _lastAccessTime: Date;
  private _isClosed: boolean;

  constructor() {
    this._proxyId = Math.random().toString(36).substring(2, 6).toUpperCase();
    this._realConnection = new RealDatabaseConnection();
    this._referenceCount = 1;
    this._queryCount = 0;
    this._lastAccessTime = new Date();
    this._isClosed = false;

    console.log(
      `[Proxy-${this._proxyId}] Smart proxy created. Reference count: ${this._referenceCount}`
    );
  }

  addReference(): void {
    this._referenceCount++;
    console.log(`[Proxy-${this._proxyId}] Reference added. Count: ${this._referenceCount}`);
  }

  releaseReference(): void {
    this._referenceCount--;
    console.log(`[Proxy-${this._proxyId}] Reference released. Count: ${this._referenceCount}`);

    if (this._referenceCount <= 0) {
      console.log(`[Proxy-${this._proxyId}] No more references - auto-closing connection`);
      this.close();
    }
  }

  executeQuery(query: string): void {
    if (this._isClosed) {
      throw new Error("Connection is closed");
    }

    this._queryCount++;
    this._lastAccessTime = new Date();

    const timeStr = this._lastAccessTime.toTimeString().slice(0, 8);
    console.log(`[Proxy-${this._proxyId}] Query #${this._queryCount} at ${timeStr}`);

    this._realConnection.executeQuery(query);
  }

  close(): void {
    if (!this._isClosed) {
      this._isClosed = true;
      this._realConnection.close();
      console.log(`[Proxy-${this._proxyId}] Statistics: ${this._queryCount} queries executed`);
    }
  }

  printStatistics(): void {
    const timeStr = this._lastAccessTime.toTimeString().slice(0, 8);
    console.log(`\n[Proxy-${this._proxyId}] --- Statistics ---`);
    console.log(`[Proxy-${this._proxyId}] Reference Count: ${this._referenceCount}`);
    console.log(`[Proxy-${this._proxyId}] Queries Executed: ${this._queryCount}`);
    console.log(`[Proxy-${this._proxyId}] Last Access: ${timeStr}`);
    console.log(`[Proxy-${this._proxyId}] Is Closed: ${this._isClosed}`);
  }
}
