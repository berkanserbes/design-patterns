namespace ProxyDesignPattern.DynamicProxyExample;

/// <summary>
/// Sample interface for a calculator service.
/// </summary>
public interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double Divide(int a, int b);
}

/// <summary>
/// Sample interface for a greeting service.
/// </summary>
public interface IGreetingService
{
    string Greet(string name);
    string Farewell(string name);
}
