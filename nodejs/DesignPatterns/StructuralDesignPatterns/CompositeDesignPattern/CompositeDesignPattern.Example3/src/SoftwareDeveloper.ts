import { Employee } from './Employee';

export class SoftwareDeveloper extends Employee {
  constructor(name: string, salary: number) { super(name, salary); }

  print(): void {
    console.log(`\tSoftware Developer Name\t\t: ${this.getName()}`);
    console.log(`\tSoftware Developer Salary\t: ${this.getSalary()}`);
  }
}
