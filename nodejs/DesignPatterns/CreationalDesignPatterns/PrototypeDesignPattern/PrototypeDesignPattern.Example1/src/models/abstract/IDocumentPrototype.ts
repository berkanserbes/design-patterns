export interface IDocumentPrototype<T> {
  clone(): T;
  deepClone(): T;
  getDocumentInfo(): string;
}
