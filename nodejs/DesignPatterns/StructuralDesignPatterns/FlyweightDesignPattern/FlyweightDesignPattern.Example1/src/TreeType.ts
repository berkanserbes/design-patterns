import { ITreeType } from './ITreeType';

// Concrete Flyweight — stores intrinsic (shared) state
export class TreeType implements ITreeType {
  constructor(
    public readonly name: string,
    public readonly color: string,
    public readonly texture: string,
  ) {}

  draw(x: number, y: number): void {
    console.log(`  Drawing '${this.name}' tree at (${x}, ${y}) - Color: ${this.color}, Texture: ${this.texture}`);
  }
}
