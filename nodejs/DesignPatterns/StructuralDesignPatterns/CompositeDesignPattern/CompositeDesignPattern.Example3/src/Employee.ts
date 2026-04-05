export abstract class Employee {
  constructor(protected readonly name: string, protected readonly salary: number) {}
  getName(): string { return this.name; }
  getSalary(): number { return this.salary; }
  abstract print(): void;
}
