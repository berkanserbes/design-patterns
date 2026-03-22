using VisitorDesignPattern.Example1;

Console.WriteLine("=== Visitor Design Pattern - Shopping Cart Example ===");
Console.WriteLine();

// --- Build the shopping cart ---
Console.WriteLine("--- Building Shopping Cart ---");
var cart = new ShoppingCart();

cart.AddProduct(new ElectronicsProduct("Laptop", 1200.00m, warrantyYears: 2));
cart.AddProduct(new ElectronicsProduct("Wireless Headphones", 150.00m, warrantyYears: 1));
cart.AddProduct(new FoodProduct("Organic Olive Oil", 18.50m, isOrganic: true));
cart.AddProduct(new FoodProduct("Pasta", 3.00m, isOrganic: false));
cart.AddProduct(new ClothingProduct("Winter Jacket", 95.00m, size: "L"));
cart.AddProduct(new ClothingProduct("Running Shoes", 75.00m, size: "42"));

Console.WriteLine($"  Subtotal: ${cart.GetSubtotal():F2}");
Console.WriteLine();

// --- Visitor 1: Tax Calculation ---
Console.WriteLine("--- Tax Calculation (TaxCalculatorVisitor) ---");
var taxVisitor = new TaxCalculatorVisitor();
cart.Accept(taxVisitor);
Console.WriteLine($"  Total Tax: ${taxVisitor.TotalTax:F2}");
Console.WriteLine();

// --- Visitor 2: Discount Calculation ---
Console.WriteLine("--- Discount Calculation (DiscountVisitor) ---");
var discountVisitor = new DiscountVisitor();
cart.Accept(discountVisitor);
Console.WriteLine($"  Total Discount: -${discountVisitor.TotalDiscount:F2}");
Console.WriteLine();

// --- Order Summary ---
Console.WriteLine("--- Order Summary ---");
decimal subtotal = cart.GetSubtotal();
decimal tax = taxVisitor.TotalTax;
decimal discount = discountVisitor.TotalDiscount;
decimal total = subtotal + tax - discount;

Console.WriteLine($"  Subtotal : ${subtotal:F2}");
Console.WriteLine($"  Tax      : +${tax:F2}");
Console.WriteLine($"  Discount : -${discount:F2}");
Console.WriteLine($"  Total    : ${total:F2}");
Console.WriteLine();
Console.WriteLine("=== End of Visitor Design Pattern Demo ===");
Console.ReadKey();
