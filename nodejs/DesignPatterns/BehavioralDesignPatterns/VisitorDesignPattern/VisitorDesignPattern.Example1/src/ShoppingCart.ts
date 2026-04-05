import { IProduct } from './IProduct';
import { IVisitor } from './IVisitor';

export class ShoppingCart {
  private readonly _products: IProduct[] = [];

  addProduct(product: IProduct): void {
    this._products.push(product);
    console.log(`  Added: ${product.name} ($${product.price.toFixed(2)})`);
  }

  getSubtotal(): number {
    return this._products.reduce((sum, p) => sum + p.price, 0);
  }

  accept(visitor: IVisitor): void {
    for (const product of this._products) {
      product.accept(visitor);
    }
  }
}
