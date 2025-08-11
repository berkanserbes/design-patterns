using AdapterDesignPattern.Example1.Adapters;
using AdapterDesignPattern.Example1.Interfaces;
using AdapterDesignPattern.Example1.Services;

var processors = new List<IPaymentProcessor>
{
	new CreditCardProcessor(),
	new PaypalAdapter(new PaypalSDK()),
	new StripeAdapter(new StripeAPI())
};


foreach (var processor in processors)
{
	processor.ProcessPayment(100.50, "TRY");
}