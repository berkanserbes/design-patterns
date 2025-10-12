using StrategyDesignPattern.Example1;

var paymentContext = new PaymentContext(new CreditCardStrategy());
paymentContext.Pay(100);

paymentContext.SetPaymentStrategy(new PayPalStrategy());
paymentContext.Pay(100);

paymentContext.SetPaymentStrategy(new ApplePayStrategy());
paymentContext.Pay(100);

Console.ReadLine();