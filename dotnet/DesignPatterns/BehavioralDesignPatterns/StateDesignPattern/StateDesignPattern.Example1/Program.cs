using StateDesignPattern.Example1;

Console.WriteLine("=== State Design Pattern - E-Commerce Order Status Example ===");
Console.WriteLine();

// Scenario 1: Successful order flow
Console.WriteLine("--- Scenario 1: Successful Order Flow ---");
var order1 = new Order("ORD-001", "Laptop");
order1.PrintStatus();

order1.Process();
order1.Ship();
order1.Deliver();

Console.WriteLine();

// Scenario 2: Order cancellation
Console.WriteLine("--- Scenario 2: Order Cancellation ---");
var order2 = new Order("ORD-002", "Smartphone");
order2.PrintStatus();

order2.Process();
order2.Cancel();

Console.WriteLine();

// Scenario 3: Invalid state transitions
Console.WriteLine("--- Scenario 3: Invalid State Transitions ---");
var order3 = new Order("ORD-003", "Headphones");
order3.PrintStatus();

order3.Ship();     // Cannot ship without processing
order3.Deliver();  // Cannot deliver without shipping

Console.WriteLine();

// Scenario 4: Operations on delivered order
Console.WriteLine("--- Scenario 4: Operations After Delivery ---");
var order4 = new Order("ORD-004", "Keyboard");
order4.Process();
order4.Ship();
order4.Deliver();
order4.Cancel();   // Cannot cancel delivered order

Console.WriteLine();
Console.WriteLine("=== End of State Design Pattern Demo ===");
