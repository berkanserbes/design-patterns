using AdapterDesignPattern.Example1.Interfaces;
using AdapterDesignPattern.Example1.Services;

namespace AdapterDesignPattern.Example1.Adapters;

public class StripeAdapter : IPaymentProcessor
{
	private readonly StripeAPI _stripeAPI;

	public StripeAdapter(StripeAPI stripeAPI)
	{
		_stripeAPI = stripeAPI;
	}

	public void ProcessPayment(double amount, string currency)
	{
		var amountCents = (int)(amount * 100);
		_stripeAPI.Charge(amountCents, currency);
	}
}
