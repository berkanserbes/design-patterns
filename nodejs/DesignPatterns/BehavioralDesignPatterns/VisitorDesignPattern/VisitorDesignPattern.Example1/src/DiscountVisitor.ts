import { IVisitor } from './IVisitor';
import { ElectronicsProduct } from './ElectronicsProduct';
import { FoodProduct } from './FoodProduct';
import { ClothingProduct } from './ClothingProduct';

export class DiscountVisitor implements IVisitor {
  private _totalDiscount: number = 0;

  get totalDiscount(): number {
    return this._totalDiscount;
  }

  visitElectronics(product: ElectronicsProduct): void {
    const discount = product.price * 0.05;
    this._totalDiscount += discount;
    console.log(`  [Discount] ${product.name}: 5% discount = -$${discount.toFixed(2)}`);
  }

  visitFood(product: FoodProduct): void {
    const discountRate = product.isOrganic ? 0.10 : 0.03;
    const discount = product.price * discountRate;
    this._totalDiscount += discount;
    const label = product.isOrganic ? '10% (organic promotion)' : '3%';
    console.log(`  [Discount] ${product.name}: ${label} discount = -$${discount.toFixed(2)}`);
  }

  visitClothing(product: ClothingProduct): void {
    const discount = product.price * 0.15;
    this._totalDiscount += discount;
    console.log(`  [Discount] ${product.name} (Size: ${product.size}): 15% seasonal sale = -$${discount.toFixed(2)}`);
  }
}
