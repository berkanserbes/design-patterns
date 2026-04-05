import { ITreeType } from './ITreeType';

// Unshared Concrete Flyweight — special trees with unique features, not shared
export class SpecialTree {
  constructor(
    public readonly x: number,
    public readonly y: number,
    public readonly name: string,
    public readonly uniqueFeature: string,
    private readonly baseType: ITreeType,
  ) {}

  draw(): void {
    console.log(`  [SPECIAL] '${this.name}' at (${this.x}, ${this.y}) - ${this.uniqueFeature}`);
    console.log(`            Base type: ${this.baseType.name}, Color: ${this.baseType.color}`);
  }
}
