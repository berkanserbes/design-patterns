import { Product } from './Product';
import { Box } from './Box';

const book = new Product('C# Programming Book', 500);
const headphones = new Product('Wireless Headphones', 200);
const phoneCase = new Product('Phone Case', 100);

const box1 = new Box('Box 1', 200);
box1.addItem(book);
box1.addItem(headphones);

const box2 = new Box('Box 2', 150);
box2.addItem(phoneCase);
box2.addItem(box1);

console.log(`${book.name} weight: ${book.getWeight()} gr`);
console.log(`${headphones.name} weight: ${headphones.getWeight()} gr`);
console.log(`${phoneCase.name} weight: ${phoneCase.getWeight()} gr`);
console.log(`${box1.name} total weight: ${box1.getWeight()} gr`);
console.log(`${box2.name} total weight: ${box2.getWeight()} gr`);
