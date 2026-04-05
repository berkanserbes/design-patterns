export interface IIterator<T> {
  hasNext(): boolean;
  next(): T;
  reset(): void;
}

export interface IAggregate<T> {
  createIterator(): IIterator<T>;
}
