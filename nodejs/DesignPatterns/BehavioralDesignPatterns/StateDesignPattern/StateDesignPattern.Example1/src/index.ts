import { Order } from './Order';

console.log('=== State Design Pattern - E-Commerce Order Status Example ===');
console.log();

// Scenario 1: Successful order flow
console.log('--- Scenario 1: Successful Order Flow ---');
const order1 = new Order('ORD-001', 'Laptop');
order1.printStatus();

order1.process();
order1.ship();
order1.deliver();

console.log();

// Scenario 2: Order cancellation
console.log('--- Scenario 2: Order Cancellation ---');
const order2 = new Order('ORD-002', 'Smartphone');
order2.printStatus();

order2.process();
order2.cancel();

console.log();

// Scenario 3: Invalid state transitions
console.log('--- Scenario 3: Invalid State Transitions ---');
const order3 = new Order('ORD-003', 'Headphones');
order3.printStatus();

order3.ship();    // Cannot ship without processing
order3.deliver(); // Cannot deliver without shipping

console.log();

// Scenario 4: Operations on delivered order
console.log('--- Scenario 4: Operations After Delivery ---');
const order4 = new Order('ORD-004', 'Keyboard');
order4.process();
order4.ship();
order4.deliver();
order4.cancel(); // Cannot cancel delivered order

console.log();
console.log('=== End of State Design Pattern Demo ===');
