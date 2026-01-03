// ============================================================================
// DYNAMIC PROXY DESIGN PATTERN
// ============================================================================
// Dynamic Proxy creates proxy objects at RUNTIME, not compile-time.
// Uses .NET's built-in DispatchProxy to intercept method calls.
// 
// Benefits:
//   - No need to create separate proxy class for each interface
//   - One proxy implementation works for ANY interface
//   - Add cross-cutting concerns (logging, timing, etc.) dynamically
//
// Pattern Structure:
//   - LoggingProxy<T>: Generic dynamic proxy using DispatchProxy
//   - Any interface can be proxied without writing specific proxy code
// ============================================================================

using ProxyDesignPattern.DynamicProxyExample;

Console.WriteLine("=== DYNAMIC PROXY PATTERN DEMO ===\n");

// Create real objects
var calculator = new Calculator();
var greetingService = new GreetingService();

// Wrap them with dynamic logging proxy
Console.WriteLine("--- Creating Dynamic Proxies ---\n");
ICalculator calcProxy = LoggingProxy<ICalculator>.Create(calculator);
IGreetingService greetProxy = LoggingProxy<IGreetingService>.Create(greetingService);

// Use calculator through proxy
Console.WriteLine("--- Using Calculator Proxy ---\n");
calcProxy.Add(10, 5);
Console.WriteLine();
calcProxy.Multiply(7, 8);
Console.WriteLine();
calcProxy.Divide(100, 4);
Console.WriteLine();

// Use greeting service through proxy
Console.WriteLine("--- Using Greeting Service Proxy ---\n");
greetProxy.Greet("John");
Console.WriteLine();
greetProxy.Farewell("John");
Console.WriteLine();

// Demonstrate exception handling
Console.WriteLine("--- Exception Handling ---\n");
try
{
    calcProxy.Divide(10, 0);
}
catch (DivideByZeroException)
{
    Console.WriteLine("[Client] Caught divide by zero exception\n");
}

Console.WriteLine("=== SUMMARY ===");
Console.WriteLine("One LoggingProxy<T> class works for ANY interface!");
Console.WriteLine("No need to write separate proxy for each service.");
