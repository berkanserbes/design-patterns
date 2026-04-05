/**
 * Sample interface for a calculator service.
 */
export interface ICalculator {
  add(a: number, b: number): number;
  subtract(a: number, b: number): number;
  multiply(a: number, b: number): number;
  divide(a: number, b: number): number;
}

/**
 * Sample interface for a greeting service.
 */
export interface IGreetingService {
  greet(name: string): string;
  farewell(name: string): string;
}
