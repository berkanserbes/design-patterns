namespace ProxyDesignPattern.RemoteProxyExample;

/// <summary>
/// Subject Interface - Common interface for payment operations.
/// </summary>
public interface IPaymentService
{
    PaymentResult ProcessPayment(decimal amount, string cardNumber);
    decimal GetBalance(string accountId);
}

/// <summary>
/// Represents the result of a payment operation.
/// </summary>
public record PaymentResult(bool Success, string TransactionId, string Message);
