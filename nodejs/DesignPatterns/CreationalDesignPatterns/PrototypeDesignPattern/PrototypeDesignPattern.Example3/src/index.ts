import { Circle } from './Circle';
import { Rectangle } from './Rectangle';

const circle = new Circle('Red', 0, 0, 5);
const copyCircle = circle.clone();
copyCircle.x = 10;
copyCircle.y = 10;

console.log('Original Circle:');
circle.display();

console.log('\nCloned Circle:');
copyCircle.display();

const rectangle = new Rectangle('Blue', 5, 5, 10, 20);
const copyRectangle = rectangle.clone();
copyRectangle.x = 15;
copyRectangle.y = 15;
copyRectangle.color = 'Orange';

console.log('\nOriginal Rectangle:');
rectangle.display();

console.log('\nCloned Rectangle:');
copyRectangle.display();
