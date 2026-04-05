import { IWorkshop } from './IWorkshop';
import { Vehicle } from './Vehicle';

export class Bike extends Vehicle {
  constructor(w1: IWorkshop, w2: IWorkshop) { super(w1, w2); }
  manufacture(): void {
    console.log(`Bike${this.workshop1.work()}${this.workshop2.work()}`);
  }
}
