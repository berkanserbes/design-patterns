import { ICalculator, IGreetingService } from "./Interfaces";

/**
 * Real implementation of ICalculator.
 */
export class Calculator implements ICalculator {
  add(a: number, b: number): number {
    return a + b;
  }

  subtract(a: number, b: number): number {
    return a - b;
  }

  multiply(a: number, b: number): number {
    return a * b;
  }

  divide(a: number, b: number): number {
    if (b === 0) throw new Error("Division by zero");
    return a / b;
  }
}

/**
 * Real implementation of IGreetingService.
 */
export class GreetingService implements IGreetingService {
  greet(name: string): string {
    return `Hello, ${name}!`;
  }

  farewell(name: string): string {
    return `Goodbye, ${name}!`;
  }
}
