package structural.proxy.remoteproxy;

public interface IPaymentService {
    PaymentResult processPayment(double amount, String cardNumber);
    double getBalance(String accountId);
}
