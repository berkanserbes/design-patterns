package structural.adapter.example1;

import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<IPaymentProcessor> processors = List.of(
            new CreditCardProcessor(),
            new PaypalAdapter(new PaypalSDK()),
            new StripeAdapter(new StripeAPI())
        );

        for (IPaymentProcessor processor : processors) {
            processor.processPayment(100.50, "TRY");
        }
    }
}
