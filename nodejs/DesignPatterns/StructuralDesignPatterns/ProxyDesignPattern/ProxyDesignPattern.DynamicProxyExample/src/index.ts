// ============================================================================
// DYNAMIC PROXY DESIGN PATTERN
// ============================================================================
// Dynamic Proxy creates proxy objects at RUNTIME, not compile-time.
// Uses JavaScript's native Proxy to intercept method calls.
//
// Benefits:
//   - No need to create separate proxy class for each interface
//   - One proxy implementation works for ANY object/interface
//   - Add cross-cutting concerns (logging, timing, etc.) dynamically
//
// Pattern Structure:
//   - createLoggingProxy<T>: Generic dynamic proxy using JS Proxy object
//   - Any interface can be proxied without writing specific proxy code
// ============================================================================

import { Calculator, GreetingService } from "./Implementations";
import { ICalculator, IGreetingService } from "./Interfaces";
import { createLoggingProxy } from "./LoggingProxy";

console.log("=== DYNAMIC PROXY PATTERN DEMO ===\n");

// Create real objects
const calculator = new Calculator();
const greetingService = new GreetingService();

// Wrap them with dynamic logging proxy
console.log("--- Creating Dynamic Proxies ---\n");
const calcProxy: ICalculator = createLoggingProxy(calculator, "ICalculator");
const greetProxy: IGreetingService = createLoggingProxy(greetingService, "IGreetingService");

// Use calculator through proxy
console.log("--- Using Calculator Proxy ---\n");
calcProxy.add(10, 5);
console.log();
calcProxy.multiply(7, 8);
console.log();
calcProxy.divide(100, 4);
console.log();

// Use greeting service through proxy
console.log("--- Using Greeting Service Proxy ---\n");
greetProxy.greet("John");
console.log();
greetProxy.farewell("John");
console.log();

// Demonstrate exception handling
console.log("--- Exception Handling ---\n");
try {
  calcProxy.divide(10, 0);
} catch (_err) {
  console.log("[Client] Caught divide by zero exception\n");
}

console.log("=== SUMMARY ===");
console.log("One createLoggingProxy<T> function works for ANY object!");
console.log("No need to write separate proxy for each service.");
