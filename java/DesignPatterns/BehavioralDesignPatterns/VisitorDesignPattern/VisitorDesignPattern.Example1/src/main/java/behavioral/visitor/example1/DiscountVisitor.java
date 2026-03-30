package behavioral.visitor.example1;

public class DiscountVisitor implements IVisitor {
    private double totalDiscount = 0;

    @Override
    public void visit(ElectronicsProduct product) {
        double discount = product.getPrice() * 0.05;
        totalDiscount += discount;
        System.out.printf("  [Discount] %s: 5%% discount = -$%.2f%n", product.getName(), discount);
    }

    @Override
    public void visit(FoodProduct product) {
        double rate = product.isOrganic() ? 0.10 : 0.03;
        double discount = product.getPrice() * rate;
        totalDiscount += discount;
        String label = product.isOrganic() ? "10% (organic promotion)" : "3%";
        System.out.printf("  [Discount] %s: %s discount = -$%.2f%n", product.getName(), label, discount);
    }

    @Override
    public void visit(ClothingProduct product) {
        double discount = product.getPrice() * 0.15;
        totalDiscount += discount;
        System.out.printf("  [Discount] %s (Size: %s): 15%% seasonal sale = -$%.2f%n",
                product.getName(), product.getSize(), discount);
    }

    public double getTotalDiscount() { return totalDiscount; }
}
