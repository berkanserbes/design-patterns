import { IPrototype } from '../abstracts/IPrototype';
import { Address } from './Address';

export class Employee implements IPrototype<Employee> {
  name: string = '';
  position: string = '';
  address?: Address;

  shallowCopy(): Employee {
    return Object.assign(new Employee(), this);
  }

  deepCopy(): Employee {
    const copy = new Employee();
    copy.name = this.name;
    copy.position = this.position;
    copy.address = this.address
      ? { street: this.address.street, city: this.address.city }
      : undefined;
    return copy;
  }
}
