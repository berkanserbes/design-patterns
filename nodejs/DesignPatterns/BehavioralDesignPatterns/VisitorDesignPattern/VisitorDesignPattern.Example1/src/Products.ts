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
