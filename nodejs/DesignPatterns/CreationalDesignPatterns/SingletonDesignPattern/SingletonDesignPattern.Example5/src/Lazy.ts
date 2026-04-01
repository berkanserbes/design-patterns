// TypeScript-native equivalent of .NET's Lazy<T>.
// Defers creation until .value is first accessed.
export class Lazy<T> {
  private _value: T | undefined = undefined;
  private _isValueCreated: boolean = false;
  private readonly _factory: () => T;

  constructor(factory: () => T) {
    this._factory = factory;
  }

  get value(): T {
    if (!this._isValueCreated) {
      this._value = this._factory();
      this._isValueCreated = true;
    }
    return this._value as T;
  }

  get isValueCreated(): boolean {
    return this._isValueCreated;
  }
}
