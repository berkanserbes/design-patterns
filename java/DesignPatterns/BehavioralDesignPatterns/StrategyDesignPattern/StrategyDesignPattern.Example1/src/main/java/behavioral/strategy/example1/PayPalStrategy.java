package behavioral.strategy.example1;

public class PayPalStrategy implements IPaymentStrategy {
    @Override
    public void pay(double amount) {
        System.out.printf("Paid $%.2f using PayPal.%n", amount);
    }
}
