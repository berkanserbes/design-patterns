import { Employee } from './Employee';

export class EmployeeComposite extends Employee {
  protected employees: Employee[] = [];

  constructor(name: string, salary: number) { super(name, salary); }

  addEmployee(employee: Employee): void { this.employees.push(employee); }
  removeEmployee(employee: Employee): void {
    const idx = this.employees.indexOf(employee);
    if (idx !== -1) this.employees.splice(idx, 1);
  }

  print(): void {
    console.log(`Employee: ${this.name}, Salary: ${this.salary}`);
    for (const e of this.employees) e.print();
  }
}
