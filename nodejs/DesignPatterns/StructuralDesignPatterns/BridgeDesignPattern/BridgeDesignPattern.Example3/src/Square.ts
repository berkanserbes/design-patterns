import { IColor } from './IColor';
import { Shape } from './Shape';

export class Square extends Shape {
  constructor(color: IColor) { super(color); }
  draw(): void { console.log('Drawing Square'); this.color.fill(); }
}
