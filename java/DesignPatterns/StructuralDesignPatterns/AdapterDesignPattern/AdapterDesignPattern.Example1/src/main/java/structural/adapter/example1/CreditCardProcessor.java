package structural.adapter.example1;

public class CreditCardProcessor implements IPaymentProcessor {
    @Override
    public void processPayment(double amount, String currency) {
        System.out.println("Credit card payment: " + amount + " " + currency);
    }
}
