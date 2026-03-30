package behavioral.strategy.example1;

public class ApplePayStrategy implements IPaymentStrategy {
    @Override
    public void pay(double amount) {
        System.out.printf("Paid $%.2f using Apple Pay.%n", amount);
    }
}
