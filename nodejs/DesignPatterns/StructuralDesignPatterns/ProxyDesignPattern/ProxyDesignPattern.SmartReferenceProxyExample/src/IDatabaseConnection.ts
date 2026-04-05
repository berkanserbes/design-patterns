/**
 * Subject Interface - Common interface for database connection.
 */
export interface IDatabaseConnection {
  executeQuery(query: string): void;
  close(): void;
}
