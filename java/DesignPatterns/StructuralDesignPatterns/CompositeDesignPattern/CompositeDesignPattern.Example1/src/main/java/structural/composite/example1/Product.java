package structural.composite.example1;

public class Product extends OrderItem {
    public double weight;

    public Product(String name, double weight) {
        super(name);
        this.weight = weight;
    }

    @Override
    public double getWeight() {
        return weight;
    }
}
