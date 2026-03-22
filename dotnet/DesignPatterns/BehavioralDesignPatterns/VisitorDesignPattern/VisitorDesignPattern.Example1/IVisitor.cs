namespace VisitorDesignPattern.Example1;

/// <summary>
/// Visitor interface that declares visit methods for each type of product element.
/// Each concrete visitor will implement different operations for each product type.
/// </summary>
public interface IVisitor
{
    void Visit(ElectronicsProduct product);
    void Visit(FoodProduct product);
    void Visit(ClothingProduct product);
}
