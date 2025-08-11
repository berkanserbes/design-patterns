using AdapterDesignPattern.Example1.Interfaces;

namespace AdapterDesignPattern.Example1.Services;

public class CreditCardProcessor : IPaymentProcessor
{
	public void ProcessPayment(double amount, string currency)
	{
		Console.WriteLine($"Credit card payment: {amount} {currency}");
	}
}