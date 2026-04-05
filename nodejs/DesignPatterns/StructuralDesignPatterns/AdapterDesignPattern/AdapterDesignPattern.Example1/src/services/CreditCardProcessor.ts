import { IPaymentProcessor } from '../interfaces/IPaymentProcessor';

export class CreditCardProcessor implements IPaymentProcessor {
  processPayment(amount: number, currency: string): void {
    console.log(`Credit card payment: ${amount} ${currency}`);
  }
}
