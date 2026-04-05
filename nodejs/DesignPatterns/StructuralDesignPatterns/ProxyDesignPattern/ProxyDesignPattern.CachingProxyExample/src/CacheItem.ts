/**
 * Represents a cached item with expiration time.
 */
export class CacheItem {
  public readonly value: string;
  public readonly expiresAt: Date;

  constructor(value: string, ttl: number) {
    this.value = value;
    this.expiresAt = new Date(Date.now() + ttl);
  }

  get isExpired(): boolean {
    return Date.now() > this.expiresAt.getTime();
  }
}
