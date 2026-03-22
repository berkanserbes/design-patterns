namespace VisitorDesignPattern.Example1;

/// <summary>
/// Concrete element: represents a clothing product.
/// Has an additional property (Size) specific to this type.
/// </summary>
public class ClothingProduct : IProduct
{
    public string Name { get; }
    public decimal Price { get; }
    public string Size { get; }

    public ClothingProduct(string name, decimal price, string size)
    {
        Name = name;
        Price = price;
        Size = size;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
