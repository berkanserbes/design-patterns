import { Mutex } from 'async-mutex';

// Double-checked locking pattern with a value parameter.
export class Singleton {
  private static _instance: Singleton | null = null;
  private static readonly _mutex = new Mutex();
  public value: string = '';

  private constructor() {}

  static async getInstance(value: string): Promise<Singleton> {
    if (!Singleton._instance) {
      const release = await Singleton._mutex.acquire();
      try {
        if (!Singleton._instance) {
          Singleton._instance = new Singleton();
          Singleton._instance.value = value;
        }
      } finally {
        release();
      }
    }
    return Singleton._instance;
  }
}
