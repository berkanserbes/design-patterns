// Eager initialization: instance is created when the class is first loaded, regardless of whether it is actually used or not.

export class Singleton {
  private static _idCounter: number = 0;
  public readonly id: number;

  private static readonly _instance: Singleton = new Singleton();

  private constructor() {
    Singleton._idCounter++;
    this.id = Singleton._idCounter;
  }

  static get getInstance(): Singleton {
    return Singleton._instance;
  }
}
