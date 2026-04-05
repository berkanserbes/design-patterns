import { IColor } from './IColor';

export abstract class Shape {
  constructor(protected readonly color: IColor) {}
  abstract draw(): void;
}
