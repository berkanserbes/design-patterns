import { IColor } from './IColor';
import { Shape } from './Shape';

export class Circle extends Shape {
  constructor(color: IColor) { super(color); }
  draw(): void { console.log('Drawing Circle'); this.color.fill(); }
}
