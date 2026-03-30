package structural.adapter.example1;

public class PaypalSDK {
    public void makePayment(String amountStr, String curr) {
        System.out.println("PayPal payment: " + amountStr + " " + curr);
    }
}
