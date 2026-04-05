import { IPaymentStrategy } from './IPaymentStrategy';

export class PaymentContext {
  private _paymentStrategy: IPaymentStrategy;

  constructor(paymentStrategy: IPaymentStrategy) {
    this._paymentStrategy = paymentStrategy;
  }

  setPaymentStrategy(paymentStrategy: IPaymentStrategy): void {
    this._paymentStrategy = paymentStrategy;
  }

  pay(amount: number): void {
    this._paymentStrategy.pay(amount);
  }
}
