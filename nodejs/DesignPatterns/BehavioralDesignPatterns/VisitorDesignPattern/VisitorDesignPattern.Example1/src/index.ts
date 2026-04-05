import { ShoppingCart } from './ShoppingCart';
import { ElectronicsProduct } from './ElectronicsProduct';
import { FoodProduct } from './FoodProduct';
import { ClothingProduct } from './ClothingProduct';
import { TaxCalculatorVisitor } from './TaxCalculatorVisitor';
import { DiscountVisitor } from './DiscountVisitor';

console.log('=== Visitor Design Pattern - Shopping Cart Example ===');
console.log();

// --- Build the shopping cart ---
console.log('--- Building Shopping Cart ---');
const cart = new ShoppingCart();

cart.addProduct(new ElectronicsProduct('Laptop', 1200.00, 2));
cart.addProduct(new ElectronicsProduct('Wireless Headphones', 150.00, 1));
cart.addProduct(new FoodProduct('Organic Olive Oil', 18.50, true));
cart.addProduct(new FoodProduct('Pasta', 3.00, false));
cart.addProduct(new ClothingProduct('Winter Jacket', 95.00, 'L'));
cart.addProduct(new ClothingProduct('Running Shoes', 75.00, '42'));

console.log(`  Subtotal: $${cart.getSubtotal().toFixed(2)}`);
console.log();

// --- Visitor 1: Tax Calculation ---
console.log('--- Tax Calculation (TaxCalculatorVisitor) ---');
const taxVisitor = new TaxCalculatorVisitor();
cart.accept(taxVisitor);
console.log(`  Total Tax: $${taxVisitor.totalTax.toFixed(2)}`);
console.log();

// --- Visitor 2: Discount Calculation ---
console.log('--- Discount Calculation (DiscountVisitor) ---');
const discountVisitor = new DiscountVisitor();
cart.accept(discountVisitor);
console.log(`  Total Discount: -$${discountVisitor.totalDiscount.toFixed(2)}`);
console.log();

// --- Order Summary ---
console.log('--- Order Summary ---');
const subtotal = cart.getSubtotal();
const tax = taxVisitor.totalTax;
const discount = discountVisitor.totalDiscount;
const total = subtotal + tax - discount;

console.log(`  Subtotal : $${subtotal.toFixed(2)}`);
console.log(`  Tax      : +$${tax.toFixed(2)}`);
console.log(`  Discount : -$${discount.toFixed(2)}`);
console.log(`  Total    : $${total.toFixed(2)}`);
console.log();
console.log('=== End of Visitor Design Pattern Demo ===');
