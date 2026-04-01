import { EmployeeComposite } from './EmployeeComposite';

export class Manager extends EmployeeComposite {
  constructor(name: string, salary: number) { super(name, salary); }

  print(): void {
    console.log(`Manager Name\t\t: ${this.getName()}`);
    console.log(`Manager Salary\t\t: ${this.getSalary()}`);
    let totalSalary = 0;
    for (const e of this.employees) {
      totalSalary += e.getSalary();
      e.print();
    }
    console.log(`Total Salary\t: ${totalSalary}`);
  }
}
