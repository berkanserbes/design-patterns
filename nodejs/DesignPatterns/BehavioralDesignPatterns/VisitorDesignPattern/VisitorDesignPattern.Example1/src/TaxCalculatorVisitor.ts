import { IVisitor } from './IVisitor';
import { ElectronicsProduct } from './ElectronicsProduct';
import { FoodProduct } from './FoodProduct';
import { ClothingProduct } from './ClothingProduct';

export class TaxCalculatorVisitor implements IVisitor {
  private _totalTax: number = 0;

  get totalTax(): number {
    return this._totalTax;
  }

  visitElectronics(product: ElectronicsProduct): void {
    const tax = product.price * 0.18;
    this._totalTax += tax;
    console.log(`  [Tax] ${product.name}: $${product.price.toFixed(2)} x 18% VAT = $${tax.toFixed(2)}`);
  }

  visitFood(product: FoodProduct): void {
    const taxRate = product.isOrganic ? 0.05 : 0.08;
    const tax = product.price * taxRate;
    this._totalTax += tax;
    const label = product.isOrganic ? '5% (organic)' : '8%';
    console.log(`  [Tax] ${product.name}: $${product.price.toFixed(2)} x ${label} VAT = $${tax.toFixed(2)}`);
  }

  visitClothing(product: ClothingProduct): void {
    const tax = product.price * 0.12;
    this._totalTax += tax;
    console.log(`  [Tax] ${product.name}: $${product.price.toFixed(2)} x 12% VAT = $${tax.toFixed(2)}`);
  }
}
