export interface IPrototype<T extends object> {
  shallowCopy(): T;
  deepCopy(): T;
}
