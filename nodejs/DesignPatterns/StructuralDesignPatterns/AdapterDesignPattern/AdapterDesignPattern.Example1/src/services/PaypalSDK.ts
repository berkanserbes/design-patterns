// Third-party PayPal SDK with incompatible interface
export class PaypalSDK {
  makePayment(amountStr: string, curr: string): void {
    console.log(`PayPal payment: ${amountStr} ${curr}`);
  }
}
