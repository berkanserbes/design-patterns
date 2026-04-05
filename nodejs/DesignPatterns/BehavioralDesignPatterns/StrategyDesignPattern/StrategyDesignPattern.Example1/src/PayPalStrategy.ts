import { IPaymentStrategy } from './IPaymentStrategy';

export class PayPalStrategy implements IPaymentStrategy {
  pay(amount: number): void {
    console.log(`Paid $${amount.toFixed(2)} using PayPal account`);
  }
}
