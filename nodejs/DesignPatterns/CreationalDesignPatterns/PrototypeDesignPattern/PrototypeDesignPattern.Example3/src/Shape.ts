export abstract class Shape {
  color: string;
  x: number;
  y: number;

  protected constructor(color: string, x: number, y: number) {
    this.color = color;
    this.x = x;
    this.y = y;
  }

  abstract clone(): Shape;

  display(): void {
    console.log(`Shape at (${this.x}, ${this.y}) with color ${this.color}`);
  }
}
