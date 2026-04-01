import { PaymentContext } from './PaymentContext';
import { CreditCardStrategy } from './CreditCardStrategy';
import { PayPalStrategy } from './PayPalStrategy';
import { ApplePayStrategy } from './ApplePayStrategy';

const paymentContext = new PaymentContext(new CreditCardStrategy());
paymentContext.pay(100);

paymentContext.setPaymentStrategy(new PayPalStrategy());
paymentContext.pay(100);

paymentContext.setPaymentStrategy(new ApplePayStrategy());
paymentContext.pay(100);
