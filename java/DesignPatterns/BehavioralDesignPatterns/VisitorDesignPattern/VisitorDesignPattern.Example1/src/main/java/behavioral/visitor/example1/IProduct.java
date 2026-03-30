package behavioral.visitor.example1;

public interface IProduct {
    String getName();
    double getPrice();
    void accept(IVisitor visitor);
}
