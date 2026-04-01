import { IPaymentStrategy } from './IPaymentStrategy';

export class CreditCardStrategy implements IPaymentStrategy {
  pay(amount: number): void {
    console.log(`Paid $${amount.toFixed(2)} using Credit Card`);
  }
}
