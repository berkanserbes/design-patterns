namespace StrategyDesignPattern.Example1;

public class ApplePayStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using Apple Pay");
    }
}