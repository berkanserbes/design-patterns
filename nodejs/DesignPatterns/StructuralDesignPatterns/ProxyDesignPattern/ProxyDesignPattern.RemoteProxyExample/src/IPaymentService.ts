/**
 * Subject Interface - Common interface for payment operations.
 */
export interface IPaymentService {
  processPayment(amount: number, cardNumber: string): Promise<PaymentResult>;
  getBalance(accountId: string): Promise<number>;
}

/**
 * Represents the result of a payment operation.
 */
export interface PaymentResult {
  success: boolean;
  transactionId: string;
  message: string;
}
