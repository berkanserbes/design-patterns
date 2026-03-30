package behavioral.visitor.example1;

public class FoodProduct implements IProduct {
    private final String name;
    private final double price;
    private final boolean organic;

    public FoodProduct(String name, double price, boolean organic) {
        this.name = name;
        this.price = price;
        this.organic = organic;
    }

    @Override
    public String getName() { return name; }

    @Override
    public double getPrice() { return price; }

    public boolean isOrganic() { return organic; }

    @Override
    public void accept(IVisitor visitor) { visitor.visit(this); }
}
