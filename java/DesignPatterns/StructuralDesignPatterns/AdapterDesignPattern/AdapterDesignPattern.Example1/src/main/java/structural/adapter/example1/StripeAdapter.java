package structural.adapter.example1;

public class StripeAdapter implements IPaymentProcessor {
    private final StripeAPI stripeAPI;

    public StripeAdapter(StripeAPI stripeAPI) {
        this.stripeAPI = stripeAPI;
    }

    @Override
    public void processPayment(double amount, String currency) {
        int amountCents = (int) (amount * 100);
        stripeAPI.charge(amountCents, currency);
    }
}
