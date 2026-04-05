import { IVisitor } from './IVisitor';

export interface IProduct {
  readonly name: string;
  readonly price: number;
  accept(visitor: IVisitor): void;
}
