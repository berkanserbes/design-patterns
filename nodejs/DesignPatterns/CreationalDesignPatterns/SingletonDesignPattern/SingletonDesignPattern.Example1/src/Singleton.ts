export class Singleton {
  private static _instance: Singleton | null = null;
  private static _idCounter: number = 0;
  public readonly id: number;

  private constructor() {
    Singleton._idCounter++;
    this.id = Singleton._idCounter;
  }

  static getOrCreateInstance(): Singleton {
    if (!Singleton._instance) {
      Singleton._instance = new Singleton();
    }
    return Singleton._instance;
  }
}
