/**
 * Subject Interface - Common interface for real document and proxy.
 */
export interface IDocument {
  read(): void;
  write(content: string): void;
  delete(): void;
}
