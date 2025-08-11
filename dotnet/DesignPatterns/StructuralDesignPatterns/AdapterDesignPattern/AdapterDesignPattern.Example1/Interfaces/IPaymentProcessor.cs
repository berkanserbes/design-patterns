namespace AdapterDesignPattern.Example1.Interfaces;

public interface IPaymentProcessor
{
	void ProcessPayment(double amount, string currency);
}
