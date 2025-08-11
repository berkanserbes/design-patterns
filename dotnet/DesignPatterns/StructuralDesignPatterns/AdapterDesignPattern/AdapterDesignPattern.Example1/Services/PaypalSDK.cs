namespace AdapterDesignPattern.Example1.Services;

public class PaypalSDK
{
	public void MakePayment(string amountStr, string curr)
	{
		Console.WriteLine($"PayPal payment: {amountStr} {curr}");
	}
}
