import { IProduct } from './IProduct';
import { IVisitor } from './IVisitor';

export class FoodProduct implements IProduct {
  readonly name: string;
  readonly price: number;
  readonly isOrganic: boolean;

  constructor(name: string, price: number, isOrganic: boolean) {
    this.name = name;
    this.price = price;
    this.isOrganic = isOrganic;
  }

  accept(visitor: IVisitor): void {
    visitor.visitFood(this);
  }
}
