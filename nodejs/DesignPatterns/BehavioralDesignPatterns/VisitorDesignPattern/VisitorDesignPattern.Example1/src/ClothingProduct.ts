import { IProduct } from './IProduct';
import { IVisitor } from './IVisitor';

export class ClothingProduct implements IProduct {
  readonly name: string;
  readonly price: number;
  readonly size: string;

  constructor(name: string, price: number, size: string) {
    this.name = name;
    this.price = price;
    this.size = size;
  }

  accept(visitor: IVisitor): void {
    visitor.visitClothing(this);
  }
}
