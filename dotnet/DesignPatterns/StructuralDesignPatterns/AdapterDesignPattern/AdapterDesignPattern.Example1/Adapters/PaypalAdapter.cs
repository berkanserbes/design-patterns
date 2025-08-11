using AdapterDesignPattern.Example1.Interfaces;
using AdapterDesignPattern.Example1.Services;

namespace AdapterDesignPattern.Example1.Adapters;

public class PaypalAdapter : IPaymentProcessor
{
	private readonly PaypalSDK _paypalSDK;

	public PaypalAdapter(PaypalSDK paypalSDK)
	{
		_paypalSDK = paypalSDK;
	}

	public void ProcessPayment(double amount, string currency)
	{
		_paypalSDK.MakePayment(amount.ToString(), currency);
	}
}
