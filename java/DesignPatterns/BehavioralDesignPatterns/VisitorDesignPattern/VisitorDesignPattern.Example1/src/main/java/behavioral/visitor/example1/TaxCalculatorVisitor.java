package behavioral.visitor.example1;

public class TaxCalculatorVisitor implements IVisitor {
    private double totalTax = 0;

    @Override
    public void visit(ElectronicsProduct product) {
        double tax = product.getPrice() * 0.18;
        totalTax += tax;
        System.out.printf("  [Tax] %s: $%.2f x 18%% VAT = $%.2f%n", product.getName(), product.getPrice(), tax);
    }

    @Override
    public void visit(FoodProduct product) {
        double taxRate = product.isOrganic() ? 0.05 : 0.08;
        double tax = product.getPrice() * taxRate;
        totalTax += tax;
        String label = product.isOrganic() ? "5% (organic)" : "8%";
        System.out.printf("  [Tax] %s: $%.2f x %s VAT = $%.2f%n", product.getName(), product.getPrice(), label, tax);
    }

    @Override
    public void visit(ClothingProduct product) {
        double tax = product.getPrice() * 0.12;
        totalTax += tax;
        System.out.printf("  [Tax] %s: $%.2f x 12%% VAT = $%.2f%n", product.getName(), product.getPrice(), tax);
    }

    public double getTotalTax() { return totalTax; }
}
