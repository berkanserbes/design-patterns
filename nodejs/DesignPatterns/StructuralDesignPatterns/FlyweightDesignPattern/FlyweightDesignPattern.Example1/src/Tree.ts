import { ITreeType } from './ITreeType';

// Context — holds extrinsic (unique) state + reference to flyweight
export class Tree {
  constructor(
    public readonly x: number,
    public readonly y: number,
    private readonly type: ITreeType,
  ) {}

  draw(): void {
    this.type.draw(this.x, this.y);
  }
}
