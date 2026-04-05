import { ElectronicsProduct } from './ElectronicsProduct';
import { FoodProduct } from './FoodProduct';
import { ClothingProduct } from './ClothingProduct';

export interface IVisitor {
  visitElectronics(product: ElectronicsProduct): void;
  visitFood(product: FoodProduct): void;
  visitClothing(product: ClothingProduct): void;
}
