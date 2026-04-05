import { IPaymentStrategy } from './IPaymentStrategy';

export class ApplePayStrategy implements IPaymentStrategy {
  pay(amount: number): void {
    console.log(`Paid $${amount.toFixed(2)} using Apple Pay`);
  }
}
