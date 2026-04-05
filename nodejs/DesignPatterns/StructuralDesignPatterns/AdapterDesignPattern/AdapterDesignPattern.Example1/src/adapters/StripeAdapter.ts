import { IPaymentProcessor } from '../interfaces/IPaymentProcessor';
import { StripeAPI } from '../services/StripeAPI';

export class StripeAdapter implements IPaymentProcessor {
  constructor(private readonly stripeAPI: StripeAPI) {}

  processPayment(amount: number, currency: string): void {
    const amountCents = Math.round(amount * 100);
    this.stripeAPI.charge(amountCents, currency);
  }
}
