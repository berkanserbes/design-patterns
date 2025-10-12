namespace StrategyDesignPattern.Example1;

public class PayPalStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using PayPal account");
    }
}
