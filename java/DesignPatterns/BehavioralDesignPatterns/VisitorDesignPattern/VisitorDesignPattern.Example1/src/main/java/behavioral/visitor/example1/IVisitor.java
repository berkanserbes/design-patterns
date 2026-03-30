package behavioral.visitor.example1;

public interface IVisitor {
    void visit(ElectronicsProduct product);
    void visit(FoodProduct product);
    void visit(ClothingProduct product);
}
