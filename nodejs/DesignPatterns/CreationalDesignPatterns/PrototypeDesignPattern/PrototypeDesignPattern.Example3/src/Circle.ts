import { Shape } from './Shape';

export class Circle extends Shape {
  radius: number;

  constructor(color: string, x: number, y: number, radius: number) {
    super(color, x, y);
    this.radius = radius;
  }

  private static fromCircle(other: Circle): Circle {
    return new Circle(other.color, other.x, other.y, other.radius);
  }

  clone(): Circle {
    return Circle.fromCircle(this);
  }

  override display(): void {
    console.log(`Circle at (${this.x}, ${this.y}) with color ${this.color} and radius ${this.radius}`);
  }
}
