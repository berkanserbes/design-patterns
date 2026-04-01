import { IPaymentProcessor } from './interfaces/IPaymentProcessor';
import { CreditCardProcessor } from './services/CreditCardProcessor';
import { PaypalAdapter } from './adapters/PaypalAdapter';
import { StripeAdapter } from './adapters/StripeAdapter';
import { PaypalSDK } from './services/PaypalSDK';
import { StripeAPI } from './services/StripeAPI';

const processors: IPaymentProcessor[] = [
  new CreditCardProcessor(),
  new PaypalAdapter(new PaypalSDK()),
  new StripeAdapter(new StripeAPI()),
];

for (const processor of processors) {
  processor.processPayment(100.50, 'TRY');
}
