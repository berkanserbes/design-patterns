package behavioral.visitor.example1;

public class ClothingProduct implements IProduct {
    private final String name;
    private final double price;
    private final String size;

    public ClothingProduct(String name, double price, String size) {
        this.name = name;
        this.price = price;
        this.size = size;
    }

    @Override
    public String getName() { return name; }

    @Override
    public double getPrice() { return price; }

    public String getSize() { return size; }

    @Override
    public void accept(IVisitor visitor) { visitor.visit(this); }
}
