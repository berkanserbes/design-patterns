import { Lazy } from './Lazy';

// Equivalent of C#: private static readonly Lazy<Singleton> _lazyInstance = new(() => new Singleton());
export class Singleton {
  private static readonly _lazyInstance = new Lazy<Singleton>(() => new Singleton());

  private constructor() {}

  static get instance(): Singleton {
    return Singleton._lazyInstance.value;
  }
}
