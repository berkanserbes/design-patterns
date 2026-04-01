export interface IPaymentProcessor {
  processPayment(amount: number, currency: string): void;
}
