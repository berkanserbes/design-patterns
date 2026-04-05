import { IPaymentProcessor } from '../interfaces/IPaymentProcessor';
import { PaypalSDK } from '../services/PaypalSDK';

export class PaypalAdapter implements IPaymentProcessor {
  constructor(private readonly paypalSDK: PaypalSDK) {}

  processPayment(amount: number, currency: string): void {
    this.paypalSDK.makePayment(amount.toString(), currency);
  }
}
