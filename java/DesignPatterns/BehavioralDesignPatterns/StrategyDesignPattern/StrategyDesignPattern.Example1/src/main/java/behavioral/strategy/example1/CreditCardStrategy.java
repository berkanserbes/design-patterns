package behavioral.strategy.example1;

public class CreditCardStrategy implements IPaymentStrategy {
    @Override
    public void pay(double amount) {
        System.out.printf("Paid $%.2f using Credit Card.%n", amount);
    }
}
