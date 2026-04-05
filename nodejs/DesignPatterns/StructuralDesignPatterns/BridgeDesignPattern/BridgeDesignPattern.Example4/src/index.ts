import { Car } from './Car';
import { Bike } from './Bike';
import { Produce } from './Produce';
import { Assemble } from './Assemble';
import { Vehicle } from './Vehicle';

const car: Vehicle = new Car(new Produce(), new Assemble());
car.manufacture();

console.log('*'.repeat(20));

const bike: Vehicle = new Bike(new Produce(), new Assemble());
bike.manufacture();
