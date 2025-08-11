namespace AdapterDesignPattern.Example1.Services;

public class StripeAPI
{
	public void Charge(int amountCents, string currency)
	{
		Console.WriteLine($"Stripe payment: {amountCents} cents {currency}");
	}
}
