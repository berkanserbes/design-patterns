package behavioral.strategy.example1;

public class PaymentContext {
    private IPaymentStrategy paymentStrategy;

    public PaymentContext(IPaymentStrategy strategy) { this.paymentStrategy = strategy; }

    public void setPaymentStrategy(IPaymentStrategy strategy) { this.paymentStrategy = strategy; }

    public void pay(double amount) { paymentStrategy.pay(amount); }
}
