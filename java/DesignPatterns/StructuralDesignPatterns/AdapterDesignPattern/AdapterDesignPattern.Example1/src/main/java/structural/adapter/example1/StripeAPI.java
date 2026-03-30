package structural.adapter.example1;

public class StripeAPI {
    public void charge(int amountCents, String currency) {
        System.out.println("Stripe payment: " + amountCents + " cents " + currency);
    }
}
