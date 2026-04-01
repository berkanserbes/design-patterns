// Third-party Stripe API with incompatible interface
export class StripeAPI {
  charge(amountCents: number, currency: string): void {
    console.log(`Stripe payment: ${amountCents} cents ${currency}`);
  }
}
