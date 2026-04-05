import { IWorkshop } from './IWorkshop';
import { Vehicle } from './Vehicle';

export class Car extends Vehicle {
  constructor(w1: IWorkshop, w2: IWorkshop) { super(w1, w2); }
  manufacture(): void {
    console.log(`Car${this.workshop1.work()}${this.workshop2.work()}`);
  }
}
