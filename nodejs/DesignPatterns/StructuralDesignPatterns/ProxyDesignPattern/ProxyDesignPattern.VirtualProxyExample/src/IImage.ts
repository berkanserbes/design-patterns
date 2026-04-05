/**
 * Subject Interface - Common interface for both the real image and its proxy.
 */
export interface IImage {
  display(): Promise<void>;
}
