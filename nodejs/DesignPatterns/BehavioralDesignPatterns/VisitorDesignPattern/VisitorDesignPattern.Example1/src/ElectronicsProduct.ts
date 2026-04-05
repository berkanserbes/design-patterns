import { IProduct } from './IProduct';
import { IVisitor } from './IVisitor';

export class ElectronicsProduct implements IProduct {
  readonly name: string;
  readonly price: number;
  readonly warrantyYears: number;

  constructor(name: string, price: number, warrantyYears: number) {
    this.name = name;
    this.price = price;
    this.warrantyYears = warrantyYears;
  }

  accept(visitor: IVisitor): void {
    visitor.visitElectronics(this);
  }
}
