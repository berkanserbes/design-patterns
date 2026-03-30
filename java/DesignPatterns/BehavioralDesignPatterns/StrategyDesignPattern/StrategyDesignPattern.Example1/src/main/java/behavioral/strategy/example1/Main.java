package behavioral.strategy.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Strategy Pattern - Payment Methods ===\n");

        PaymentContext context = new PaymentContext(new CreditCardStrategy());
        context.pay(100.00);

        context.setPaymentStrategy(new PayPalStrategy());
        context.pay(100.00);

        context.setPaymentStrategy(new ApplePayStrategy());
        context.pay(100.00);
    }
}
