namespace VisitorDesignPattern.Example1;

/// <summary>
/// Concrete element: represents a food product.
/// Has an additional property (IsOrganic) specific to this type.
/// </summary>
public class FoodProduct : IProduct
{
    public string Name { get; }
    public decimal Price { get; }
    public bool IsOrganic { get; }

    public FoodProduct(string name, decimal price, bool isOrganic)
    {
        Name = name;
        Price = price;
        IsOrganic = isOrganic;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
