namespace ProxyDesignPattern.DynamicProxyExample;

/// <summary>
/// Real implementation of ICalculator.
/// </summary>
public class Calculator : ICalculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public double Divide(int a, int b) => b != 0 ? (double)a / b : throw new DivideByZeroException();
}

/// <summary>
/// Real implementation of IGreetingService.
/// </summary>
public class GreetingService : IGreetingService
{
    public string Greet(string name) => $"Hello, {name}!";
    public string Farewell(string name) => $"Goodbye, {name}!";
}
