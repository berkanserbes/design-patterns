import { Circle } from './Circle';
import { Square } from './Square';
import { Red } from './Red';
import { Green } from './Green';
import { Shape } from './Shape';

const redCircle: Shape = new Circle(new Red());
const greenSquare: Shape = new Square(new Green());

redCircle.draw();
greenSquare.draw();
