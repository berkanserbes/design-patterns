package structural.composite.example1;

import java.util.ArrayList;
import java.util.List;

public class Box extends OrderItem {
    private final List<OrderItem> items = new ArrayList<>();
    private final double boxWeight;

    public Box(String name, double boxWeight) {
        super(name);
        this.boxWeight = boxWeight;
    }

    @Override
    public double getWeight() {
        return boxWeight + items.stream().mapToDouble(OrderItem::getWeight).sum();
    }

    public void addItem(OrderItem item) { items.add(item); }
    public void removeItem(OrderItem item) { items.remove(item); }
}
