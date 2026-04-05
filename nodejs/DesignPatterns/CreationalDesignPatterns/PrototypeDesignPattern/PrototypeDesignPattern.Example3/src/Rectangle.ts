import { Shape } from './Shape';

export class Rectangle extends Shape {
  width: number;
  height: number;

  constructor(color: string, x: number, y: number, width: number, height: number) {
    super(color, x, y);
    this.width = width;
    this.height = height;
  }

  private static fromRectangle(other: Rectangle): Rectangle {
    return new Rectangle(other.color, other.x, other.y, other.width, other.height);
  }

  clone(): Rectangle {
    return Rectangle.fromRectangle(this);
  }

  override display(): void {
    console.log(`Rectangle at (${this.x}, ${this.y}) with dimensions ${this.width}x${this.height} and color ${this.color}`);
  }
}
