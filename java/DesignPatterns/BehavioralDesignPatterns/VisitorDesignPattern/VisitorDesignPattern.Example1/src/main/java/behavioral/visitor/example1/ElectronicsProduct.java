package behavioral.visitor.example1;

public class ElectronicsProduct implements IProduct {
    private final String name;
    private final double price;
    private final int warrantyYears;

    public ElectronicsProduct(String name, double price, int warrantyYears) {
        this.name = name;
        this.price = price;
        this.warrantyYears = warrantyYears;
    }

    @Override
    public String getName() { return name; }

    @Override
    public double getPrice() { return price; }

    public int getWarrantyYears() { return warrantyYears; }

    @Override
    public void accept(IVisitor visitor) { visitor.visit(this); }
}
