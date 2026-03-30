package structural.adapter.example1;

public class PaypalAdapter implements IPaymentProcessor {
    private final PaypalSDK paypalSDK;

    public PaypalAdapter(PaypalSDK paypalSDK) {
        this.paypalSDK = paypalSDK;
    }

    @Override
    public void processPayment(double amount, String currency) {
        paypalSDK.makePayment(String.valueOf(amount), currency);
    }
}
