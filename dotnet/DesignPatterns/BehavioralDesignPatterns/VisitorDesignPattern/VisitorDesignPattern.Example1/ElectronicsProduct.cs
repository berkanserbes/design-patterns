namespace VisitorDesignPattern.Example1;

/// <summary>
/// Concrete element: represents an electronics product.
/// Has an additional property (WarrantyYears) specific to this type.
/// </summary>
public class ElectronicsProduct : IProduct
{
    public string Name { get; }
    public decimal Price { get; }
    public int WarrantyYears { get; }

    public ElectronicsProduct(string name, decimal price, int warrantyYears)
    {
        Name = name;
        Price = price;
        WarrantyYears = warrantyYears;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
