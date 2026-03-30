package structural.composite.example1;

public abstract class OrderItem {
    public String name;

    protected OrderItem(String name) {
        this.name = name;
    }

    public abstract double getWeight();
}
