package behavioral.visitor.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Visitor Design Pattern - Shopping Cart Example ===\n");

        System.out.println("--- Building Shopping Cart ---");
        ShoppingCart cart = new ShoppingCart();
        cart.addProduct(new ElectronicsProduct("Laptop", 1200.00, 2));
        cart.addProduct(new ElectronicsProduct("Wireless Headphones", 150.00, 1));
        cart.addProduct(new FoodProduct("Organic Olive Oil", 18.50, true));
        cart.addProduct(new FoodProduct("Pasta", 3.00, false));
        cart.addProduct(new ClothingProduct("Winter Jacket", 95.00, "L"));
        cart.addProduct(new ClothingProduct("Running Shoes", 75.00, "42"));
        System.out.printf("  Subtotal: $%.2f%n%n", cart.getSubtotal());

        System.out.println("--- Tax Calculation (TaxCalculatorVisitor) ---");
        TaxCalculatorVisitor taxVisitor = new TaxCalculatorVisitor();
        cart.accept(taxVisitor);
        System.out.printf("  Total Tax: $%.2f%n%n", taxVisitor.getTotalTax());

        System.out.println("--- Discount Calculation (DiscountVisitor) ---");
        DiscountVisitor discountVisitor = new DiscountVisitor();
        cart.accept(discountVisitor);
        System.out.printf("  Total Discount: -$%.2f%n%n", discountVisitor.getTotalDiscount());

        System.out.println("--- Order Summary ---");
        double subtotal = cart.getSubtotal();
        double tax = taxVisitor.getTotalTax();
        double discount = discountVisitor.getTotalDiscount();
        double total = subtotal + tax - discount;
        System.out.printf("  Subtotal : $%.2f%n", subtotal);
        System.out.printf("  Tax      : +$%.2f%n", tax);
        System.out.printf("  Discount : -$%.2f%n", discount);
        System.out.printf("  Total    : $%.2f%n%n", total);
        System.out.println("=== End of Visitor Design Pattern Demo ===");
    }
}
