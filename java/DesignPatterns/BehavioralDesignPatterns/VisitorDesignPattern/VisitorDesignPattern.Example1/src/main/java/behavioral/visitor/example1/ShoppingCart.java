package behavioral.visitor.example1;

import java.util.ArrayList;
import java.util.List;

public class ShoppingCart {
    private final List<IProduct> products = new ArrayList<>();

    public void addProduct(IProduct product) {
        products.add(product);
        System.out.printf("  Added: %s ($%.2f)%n", product.getName(), product.getPrice());
    }

    public double getSubtotal() {
        return products.stream().mapToDouble(IProduct::getPrice).sum();
    }

    public void accept(IVisitor visitor) {
        for (IProduct product : products) {
            product.accept(visitor);
        }
    }
}
